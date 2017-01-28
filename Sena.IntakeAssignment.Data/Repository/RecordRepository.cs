using System;
using System.Collections.Generic;
using Sena.IntakeAssignment.Data.Model;

namespace Sena.IntakeAssignment.Data.Repository
{
    public class RecordRepository
    {
        #region Data

        private readonly List<Record> _records = new List<Record>
        {
            new Record
            {
                Id = 1,
                Artist = "Hazes, Andre",
                AlbumTitle = "IK BEN ZOALS IK BEN",
                CatalogueNumber = "RHBCD",
                Title = "DE OUDE MUZIKANT",
                IsrcCode = "NLQ901000135",
                Year = 2010
            },
            new Record
            {
                Id = 2,
                Artist = "Hazes, Andre",
                AlbumTitle = "IK BEN ZOALS IK BEN",
                CatalogueNumber = "RHBCD",
                Title = "DE OUDE VENTER",
                IsrcCode = "NLQ901000132",
                Year = 2010
            },
            new Record
            {
                Id = 3,
                Artist = "Hazes, Andre",
                AlbumTitle = "IK BEN ZOALS IK BEN",
                CatalogueNumber = "RHBCD",
                Title = "DIE ZOMERNACHT IN MEXICO",
                IsrcCode = "NLQ901000134",
                Year = 2010
            },
            new Record
            {
                Id = 4,
                Artist = "Hazes, Andre",
                AlbumTitle = "IK BEN ZOALS IK BEN",
                CatalogueNumber = "RHBCD",
                Title = "DOE 'T GOED",
                IsrcCode = "NLQ901000127",
                Year = 2010
            },
            new Record
            {
                Id = 5,
                Artist = "Hazes, Andre",
                AlbumTitle = "IK BEN ZOALS IK BEN",
                CatalogueNumber = "RHBCD",
                Title = "FENDER MEDLEY",
                IsrcCode = "NLQ901000133",
                Year = 2010
            },
            new Record
            {
                Id = 6,
                Artist = "Hazes, Andre",
                AlbumTitle = "IK BEN ZOALS IK BEN",
                CatalogueNumber = "RHBCD",
                Title = "IK BEN EEN VAGABUNDO",
                IsrcCode = "NLQ901000130",
                Year = 2010
            },
            new Record
            {
                Id = 7,
                Artist = "Hazes, Andre",
                AlbumTitle = "IK BEN ZOALS IK BEN",
                CatalogueNumber = "RHBCD",
                Title = "IK BEN WEER VRIJGEZEL",
                IsrcCode = "NLQ901000131",
                Year = 2010
            },
            new Record
            {
                Id = 8,
                Artist = "Hazes, Andre",
                AlbumTitle = "IK BEN ZOALS IK BEN",
                CatalogueNumber = "RHBCD",
                Title = "IK HOU VAN JOU",
                IsrcCode = "NLQ901000126",
                Year = 2010
            },
            new Record
            {
                Id = 9,
                Artist = "Hazes, Andre",
                AlbumTitle = "IK BEN ZOALS IK BEN",
                CatalogueNumber = "RHBCD",
                Title = "KOM MAAR 'NS BINNEN",
                IsrcCode = "NLQ901000136",
                Year = 2010
            },
            new Record
            {
                Id = 10,
                Artist = "Hazes, Andre",
                AlbumTitle = "IK BEN ZOALS IK BEN",
                CatalogueNumber = "RHBCD",
                Title = "LEEF JIJ MAAR RAAK",
                IsrcCode = "NLQ901000124",
                Year = 2010
            },
            new Record
            {
                Id = 11,
                Artist = "Hazes, Andre",
                AlbumTitle = "IK BEN ZOALS IK BEN",
                CatalogueNumber = "RHBCD",
                Title = "LEVENSMEDLEY",
                IsrcCode = "NLQ901000123",
                Year = 2010
            },
            new Record
            {
                Id = 12,
                Artist = "Hazes, Andre",
                AlbumTitle = "IK BEN ZOALS IK BEN",
                CatalogueNumber = "RHBCD",
                Title = "MAAR TOCH BLIJF JIJ MIJ TROUW",
                IsrcCode = "NLQ901000125",
                Year = 2010
            },
            new Record
            {
                Id = 13,
                Artist = "Hazes, Andre",
                AlbumTitle = "IK BEN ZOALS IK BEN",
                CatalogueNumber = "RHBCD",
                Title = "TANGO MEDLEY",
                IsrcCode = "NLQ901000129",
                Year = 2010
            },
            new Record
            {
                Id = 14,
                Artist = "Hazes, Andre",
                AlbumTitle = "IK BEN ZOALS IK BEN",
                CatalogueNumber = "RHBCD",
                Title = "VERLOREN TIJD",
                IsrcCode = "NLQ901000137",
                Year = 2010
            },
            new Record
            {
                Id = 15,
                Artist = "Hazes, Andre",
                AlbumTitle = "IK BEN ZOALS IK BEN",
                CatalogueNumber = "RHBCD",
                Title = "ANT ALS JE ME NOU ZOU ZIEN",
                IsrcCode = "NLQ901000128",
                Year = 2010
            }
        };

        #endregion

        public IEnumerable<Record> FetchRecordList()
        {
            return _records;
        }

        public Record Update(Record record)
        {
            throw new NotImplementedException();
        }

        public bool Add(Record record)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Record record)
        {
            throw new NotImplementedException();
        }
    }
}