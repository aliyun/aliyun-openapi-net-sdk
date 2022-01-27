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
using Aliyun.Acs.imm.Transform;
using Aliyun.Acs.imm.Transform.V20170906;

namespace Aliyun.Acs.imm.Model.V20170906
{
    public class GetWebofficeURLRequest : RpcAcsRequest<GetWebofficeURLResponse>
    {
        public GetWebofficeURLRequest()
            : base("imm", "2017-09-06", "GetWebofficeURL", "imm", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.imm.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.imm.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string srcType;

		private string project;

		private string file;

		private bool? hidecmb;

		private string notifyEndpoint;

		private string fileID;

		private string watermark;

		private string notifyTopicName;

		private string permission;

		private string user;

		public string SrcType
		{
			get
			{
				return srcType;
			}
			set	
			{
				srcType = value;
				DictionaryUtil.Add(QueryParameters, "SrcType", value);
			}
		}

		public string Project
		{
			get
			{
				return project;
			}
			set	
			{
				project = value;
				DictionaryUtil.Add(QueryParameters, "Project", value);
			}
		}

		public string File
		{
			get
			{
				return file;
			}
			set	
			{
				file = value;
				DictionaryUtil.Add(QueryParameters, "File", value);
			}
		}

		public bool? Hidecmb
		{
			get
			{
				return hidecmb;
			}
			set	
			{
				hidecmb = value;
				DictionaryUtil.Add(QueryParameters, "Hidecmb", value.ToString());
			}
		}

		public string NotifyEndpoint
		{
			get
			{
				return notifyEndpoint;
			}
			set	
			{
				notifyEndpoint = value;
				DictionaryUtil.Add(QueryParameters, "NotifyEndpoint", value);
			}
		}

		public string FileID
		{
			get
			{
				return fileID;
			}
			set	
			{
				fileID = value;
				DictionaryUtil.Add(QueryParameters, "FileID", value);
			}
		}

		public string Watermark
		{
			get
			{
				return watermark;
			}
			set	
			{
				watermark = value;
				DictionaryUtil.Add(QueryParameters, "Watermark", value);
			}
		}

		public string NotifyTopicName
		{
			get
			{
				return notifyTopicName;
			}
			set	
			{
				notifyTopicName = value;
				DictionaryUtil.Add(QueryParameters, "NotifyTopicName", value);
			}
		}

		public string Permission
		{
			get
			{
				return permission;
			}
			set	
			{
				permission = value;
				DictionaryUtil.Add(QueryParameters, "Permission", value);
			}
		}

		public string User
		{
			get
			{
				return user;
			}
			set	
			{
				user = value;
				DictionaryUtil.Add(QueryParameters, "User", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetWebofficeURLResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetWebofficeURLResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
