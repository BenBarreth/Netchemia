using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Netchemia_081213.Classes
{
    public class Transcript
    {
        public int StudentId { get; set; }
        public int TranscriptId { get; set; }
        public string TranscriptName { get; set; }
        public string DegreeName { get; set; }
        public string DegreeLevel { get; set; }
        public decimal GPA { get; set; }

        public Transcript() { }

        public Transcript(int studentId) 
        {
            Transcript t = new Transcript();
            t = DatabaseFaker.Transcripts.Where(x => x.StudentId == studentId).FirstOrDefault();
            MapProperties(t);
        }

        #region helpers
        private void MapProperties(Transcript t)
        {
            StudentId = t.StudentId;
            TranscriptId = t.TranscriptId;
            TranscriptName = t.TranscriptName;
            DegreeLevel = t.DegreeLevel;
            DegreeName = t.DegreeName;
            GPA = t.GPA;
        }
        #endregion helpers
    }
}