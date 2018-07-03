﻿using System;
using System.IO;

using CodeArt.IO;

namespace CodeArt.Web.WebPages
{
    internal class RepositoryBodyWriter : BodyWriter
    {
        private IUploadRepository _repository;
        public string TempKey
        {
            get;
            private set;
        }

        public string ServerKey
        {
            get;
            private set;
        }

        public string ClientFileName
        {
            get;
            private set;
        }

        public RepositoryBodyWriter(IUploadRepository repository, string clientFileName)
        {
            if (repository == null) throw new ArgumentNullException("repository");
            _repository = repository;
            this.ClientFileName = clientFileName;
            this.TempKey = _repository.Begin(IOUtil.GetExtension(clientFileName));
        }

        public override void Close()
        {
            this.ServerKey = _repository.Close(this.TempKey);
        }

        public override void Write(byte[] buffer, int index, int count)
        {
            _repository.Write(this.TempKey, buffer, index, count);
            base._size += count;
        }

        public override string Content
        {
            get
            {
                return null;
            }
        }
    }
}