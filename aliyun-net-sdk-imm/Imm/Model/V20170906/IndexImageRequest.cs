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
    public class IndexImageRequest : RpcAcsRequest<IndexImageResponse>
    {
        public IndexImageRequest()
            : base("imm", "2017-09-06", "IndexImage", "imm", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.imm.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.imm.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string project;

		private string externalId;

		private string notifyEndpoint;

		private string sourceType;

		private string notifyTopicName;

		private string remarksB;

		private string remarksA;

		private string imageUri;

		private string remarksArrayA;

		private string remarksArrayB;

		private string sourceUri;

		private string sourcePosition;

		private string remarksD;

		private string remarksC;

		private string setId;

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

		public string ExternalId
		{
			get
			{
				return externalId;
			}
			set	
			{
				externalId = value;
				DictionaryUtil.Add(QueryParameters, "ExternalId", value);
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

		public string SourceType
		{
			get
			{
				return sourceType;
			}
			set	
			{
				sourceType = value;
				DictionaryUtil.Add(QueryParameters, "SourceType", value);
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

		public string RemarksB
		{
			get
			{
				return remarksB;
			}
			set	
			{
				remarksB = value;
				DictionaryUtil.Add(QueryParameters, "RemarksB", value);
			}
		}

		public string RemarksA
		{
			get
			{
				return remarksA;
			}
			set	
			{
				remarksA = value;
				DictionaryUtil.Add(QueryParameters, "RemarksA", value);
			}
		}

		public string ImageUri
		{
			get
			{
				return imageUri;
			}
			set	
			{
				imageUri = value;
				DictionaryUtil.Add(QueryParameters, "ImageUri", value);
			}
		}

		public string RemarksArrayA
		{
			get
			{
				return remarksArrayA;
			}
			set	
			{
				remarksArrayA = value;
				DictionaryUtil.Add(QueryParameters, "RemarksArrayA", value);
			}
		}

		public string RemarksArrayB
		{
			get
			{
				return remarksArrayB;
			}
			set	
			{
				remarksArrayB = value;
				DictionaryUtil.Add(QueryParameters, "RemarksArrayB", value);
			}
		}

		public string SourceUri
		{
			get
			{
				return sourceUri;
			}
			set	
			{
				sourceUri = value;
				DictionaryUtil.Add(QueryParameters, "SourceUri", value);
			}
		}

		public string SourcePosition
		{
			get
			{
				return sourcePosition;
			}
			set	
			{
				sourcePosition = value;
				DictionaryUtil.Add(QueryParameters, "SourcePosition", value);
			}
		}

		public string RemarksD
		{
			get
			{
				return remarksD;
			}
			set	
			{
				remarksD = value;
				DictionaryUtil.Add(QueryParameters, "RemarksD", value);
			}
		}

		public string RemarksC
		{
			get
			{
				return remarksC;
			}
			set	
			{
				remarksC = value;
				DictionaryUtil.Add(QueryParameters, "RemarksC", value);
			}
		}

		public string SetId
		{
			get
			{
				return setId;
			}
			set	
			{
				setId = value;
				DictionaryUtil.Add(QueryParameters, "SetId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override IndexImageResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return IndexImageResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
