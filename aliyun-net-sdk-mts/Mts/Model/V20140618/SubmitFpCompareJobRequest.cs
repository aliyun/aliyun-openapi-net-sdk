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
using Aliyun.Acs.Mts.Transform;
using Aliyun.Acs.Mts.Transform.V20140618;

namespace Aliyun.Acs.Mts.Model.V20140618
{
    public class SubmitFpCompareJobRequest : RpcAcsRequest<SubmitFpCompareJobResponse>
    {
        public SubmitFpCompareJobRequest()
            : base("Mts", "2014-06-18", "SubmitFpCompareJob", "mts", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private long? resourceOwnerId;

		private string fpDBId;

		private string masterMedia;

		private string userData;

		private string queryMedia;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private string pipelineId;

		private string matchedFrameStorage;

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

		public string FpDBId
		{
			get
			{
				return fpDBId;
			}
			set	
			{
				fpDBId = value;
				DictionaryUtil.Add(QueryParameters, "FpDBId", value);
			}
		}

		public string MasterMedia
		{
			get
			{
				return masterMedia;
			}
			set	
			{
				masterMedia = value;
				DictionaryUtil.Add(QueryParameters, "MasterMedia", value);
			}
		}

		public string UserData
		{
			get
			{
				return userData;
			}
			set	
			{
				userData = value;
				DictionaryUtil.Add(QueryParameters, "UserData", value);
			}
		}

		public string QueryMedia
		{
			get
			{
				return queryMedia;
			}
			set	
			{
				queryMedia = value;
				DictionaryUtil.Add(QueryParameters, "QueryMedia", value);
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

		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
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

		public string PipelineId
		{
			get
			{
				return pipelineId;
			}
			set	
			{
				pipelineId = value;
				DictionaryUtil.Add(QueryParameters, "PipelineId", value);
			}
		}

		public string MatchedFrameStorage
		{
			get
			{
				return matchedFrameStorage;
			}
			set	
			{
				matchedFrameStorage = value;
				DictionaryUtil.Add(QueryParameters, "MatchedFrameStorage", value);
			}
		}

        public override SubmitFpCompareJobResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SubmitFpCompareJobResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
