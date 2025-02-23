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
using Aliyun.Acs.NAS.Transform;
using Aliyun.Acs.NAS.Transform.V20170626;

namespace Aliyun.Acs.NAS.Model.V20170626
{
    public class ModifySmbAclRequest : RpcAcsRequest<ModifySmbAclResponse>
    {
        public ModifySmbAclRequest()
            : base("NAS", "2017-06-26", "ModifySmbAcl", "nas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.NAS.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.NAS.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private bool? encryptData;

		private string keytab;

		private string superAdminSid;

		private string keytabMd5;

		private bool? rejectUnencryptedAccess;

		private string fileSystemId;

		private string homeDirPath;

		private bool? enableAnonymousAccess;

		[JsonProperty(PropertyName = "EncryptData")]
		public bool? EncryptData
		{
			get
			{
				return encryptData;
			}
			set	
			{
				encryptData = value;
				DictionaryUtil.Add(QueryParameters, "EncryptData", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "Keytab")]
		public string Keytab
		{
			get
			{
				return keytab;
			}
			set	
			{
				keytab = value;
				DictionaryUtil.Add(QueryParameters, "Keytab", value);
			}
		}

		[JsonProperty(PropertyName = "SuperAdminSid")]
		public string SuperAdminSid
		{
			get
			{
				return superAdminSid;
			}
			set	
			{
				superAdminSid = value;
				DictionaryUtil.Add(QueryParameters, "SuperAdminSid", value);
			}
		}

		[JsonProperty(PropertyName = "KeytabMd5")]
		public string KeytabMd5
		{
			get
			{
				return keytabMd5;
			}
			set	
			{
				keytabMd5 = value;
				DictionaryUtil.Add(QueryParameters, "KeytabMd5", value);
			}
		}

		[JsonProperty(PropertyName = "RejectUnencryptedAccess")]
		public bool? RejectUnencryptedAccess
		{
			get
			{
				return rejectUnencryptedAccess;
			}
			set	
			{
				rejectUnencryptedAccess = value;
				DictionaryUtil.Add(QueryParameters, "RejectUnencryptedAccess", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "FileSystemId")]
		public string FileSystemId
		{
			get
			{
				return fileSystemId;
			}
			set	
			{
				fileSystemId = value;
				DictionaryUtil.Add(QueryParameters, "FileSystemId", value);
			}
		}

		[JsonProperty(PropertyName = "HomeDirPath")]
		public string HomeDirPath
		{
			get
			{
				return homeDirPath;
			}
			set	
			{
				homeDirPath = value;
				DictionaryUtil.Add(QueryParameters, "HomeDirPath", value);
			}
		}

		[JsonProperty(PropertyName = "EnableAnonymousAccess")]
		public bool? EnableAnonymousAccess
		{
			get
			{
				return enableAnonymousAccess;
			}
			set	
			{
				enableAnonymousAccess = value;
				DictionaryUtil.Add(QueryParameters, "EnableAnonymousAccess", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ModifySmbAclResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifySmbAclResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
