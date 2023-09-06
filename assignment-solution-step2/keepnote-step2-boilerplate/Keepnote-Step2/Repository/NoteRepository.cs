using System;
using System.Collections.Generic;
using System.Linq;
using Keepnote.Models;
using Microsoft.EntityFrameworkCore;

namespace Keepnote.Repository
{
    public class NoteRepository : INoteRepository
    {
        private readonly KeepNoteContext context;

        public NoteRepository(KeepNoteContext context)
        {
            this.context = context;
        }

        // Save the note in the database(note) table.
        public int AddNote(Note note)
        {
            context.Notes.Add(note);
            return context.SaveChanges();
        }
        //Remove the note from the database(note) table.
        public int DeletNote(int noteId)
        {
            Note note = GetNoteById(noteId);
            context.Notes.Remove(note);
            return context.SaveChanges();
        }

        //can be used as helper method for controller
        public bool Exists(int noteId)
        {
            Note note = GetNoteById(noteId);
            if(note != null)
            {
                return true;
            }
            return false;
        }

        /* retrieve all existing notes sorted by created Date in descending
         order(showing latest note first)*/
        public List<Note> GetAllNotes()
        {
            return context.Notes.ToList();
        }

        //retrieve specific note from the database(note) table
        public Note GetNoteById(int noteId)
        {
            return context.Notes.Where(note => note.NoteId == noteId).FirstOrDefault();
        }
        //Update existing note
        public int UpdateNote(Note note)
        {
            Note noteObj = GetNoteById(note.NoteId);
            noteObj.NoteTitle = note.NoteTitle;
            noteObj.NoteContent = note.NoteContent;
            noteObj.NoteStatus = note.NoteStatus;
            return context.SaveChanges();
        }

    }
}
