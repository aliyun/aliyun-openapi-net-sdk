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

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Dysmsapi.Transform;
using Aliyun.Acs.Dysmsapi.Transform.V20170525;

namespace Aliyun.Acs.Dysmsapi.Model.V20170525
{
    public class AddSmsSignRequest : RpcAcsRequest<AddSmsSignResponse>
    {
        public AddSmsSignRequest()
            : base("Dysmsapi", "2017-05-25", "AddSmsSign", "dysms", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private long? resourceOwnerId;

		private string remark;

		private string signName;

		private List<SignFileList> signFileLists = new List<SignFileList>(){ };

		private string resourceOwnerAccount;

		private long? ownerId;

		private int? signSource;

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string Remark
		{
			get
			{
				return remark;
			}
			set	
			{
				remark = value;
				DictionaryUtil.Add(QueryParameters, "Remark", value);
			}
		}

		public string SignName
		{
			get
			{
				return signName;
			}
			set	
			{
				signName = value;
				DictionaryUtil.Add(QueryParameters, "SignName", value);
			}
		}

		public List<SignFileList> SignFileLists
		{
			get
			{
				return signFileLists;
			}

			set
			{
				signFileLists = value;
				for (int i = 0; i < signFileLists.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"SignFileList." + (i + 1) + ".FileContents", signFileLists[i].FileContents);
					DictionaryUtil.Add(QueryParameters,"SignFileList." + (i + 1) + ".FileSuffix", signFileLists[i].FileSuffix);
				}
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public int? SignSource
		{
			get
			{
				return signSource;
			}
			set	
			{
				signSource = value;
				DictionaryUtil.Add(QueryParameters, "SignSource", value.ToString());
			}
		}

		public class SignFileList
		{

			private string fileContents;

			private string fileSuffix;

			public string FileContents
			{
				get
				{
					return fileContents;
				}
				set	
				{
					fileContents = value;
				}
			}

			public string FileSuffix
			{
				get
				{
					return fileSuffix;
				}
				set	
				{
					fileSuffix = value;
				}
			}
		}

        public override AddSmsSignResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddSmsSignResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
