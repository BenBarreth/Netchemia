using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Netchemia_081213.Classes
{
    public static class DatabaseFaker
    {
        private static List<Transcript> _transcripts = new List<Transcript>(){
            // populate fake data here
            new Transcript(){
                StudentId = 1,
                TranscriptId = 3242343,
                TranscriptName = "Transcript for the University of Netchemia",
                DegreeName = "Physics",
                DegreeLevel = "Bachelor's",
                GPA = 4.0M,
            },
            new Transcript(){
                StudentId = 2,
                TranscriptId = 987976,
                TranscriptName = "Transcript for the University of Netchemia",
                DegreeName = "Philosophy",
                DegreeLevel = "Master's",
                GPA = 3.5M,
            },
            new Transcript(){
                StudentId = 3,
                TranscriptId = 6546546,
                TranscriptName = "Transcript for the University of Netchemia",
                DegreeName = "Law",
                DegreeLevel = "Doctorate",
                GPA = 4.5M,
            }
        };

        public static List<Transcript> Transcripts {
            get { return _transcripts; }
            set { _transcripts = value; }
        }
    }
}