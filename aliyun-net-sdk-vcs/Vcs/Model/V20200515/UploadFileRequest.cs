/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Vcs;
using Aliyun.Acs.Vcs.Transform;
using Aliyun.Acs.Vcs.Transform.V20200515;

namespace Aliyun.Acs.Vcs.Model.V20200515
{
    public class UploadFileRequest : RpcAcsRequest<UploadFileResponse>
    {
        public UploadFileRequest()
            : base("Vcs", "2020-05-15", "UploadFile")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string fileType;

		private string corpId;

		private string fileAliasName;

		private string fileName;

		private string filePath;

		private string fileContent;

		private string dataSourceId;

		private string mD5;

		public string FileType
		{
			get
			{
				return fileType;
			}
			set	
			{
				fileType = value;
				DictionaryUtil.Add(BodyParameters, "FileType", value);
			}
		}

		public string CorpId
		{
			get
			{
				return corpId;
			}
			set	
			{
				corpId = value;
				DictionaryUtil.Add(BodyParameters, "CorpId", value);
			}
		}

		public string FileAliasName
		{
			get
			{
				return fileAliasName;
			}
			set	
			{
				fileAliasName = value;
				DictionaryUtil.Add(BodyParameters, "FileAliasName", value);
			}
		}

		public string FileName
		{
			get
			{
				return fileName;
			}
			set	
			{
				fileName = value;
				DictionaryUtil.Add(BodyParameters, "FileName", value);
			}
		}

		public string FilePath
		{
			get
			{
				return filePath;
			}
			set	
			{
				filePath = value;
				DictionaryUtil.Add(BodyParameters, "FilePath", value);
			}
		}

		public string FileContent
		{
			get
			{
				return fileContent;
			}
			set	
			{
				fileContent = value;
				DictionaryUtil.Add(BodyParameters, "FileContent", value);
			}
		}

		public string DataSourceId
		{
			get
			{
				return dataSourceId;
			}
			set	
			{
				dataSourceId = value;
				DictionaryUtil.Add(BodyParameters, "DataSourceId", value);
			}
		}

		public string MD5
		{
			get
			{
				return mD5;
			}
			set	
			{
				mD5 = value;
				DictionaryUtil.Add(BodyParameters, "MD5", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UploadFileResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UploadFileResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
