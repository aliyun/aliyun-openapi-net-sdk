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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Mts.Transform;
using Aliyun.Acs.Mts.Transform.V20140618;
using System.Collections.Generic;

namespace Aliyun.Acs.Mts.Model.V20140618
{
    public class SubmitEditingJobsRequest : RpcAcsRequest<SubmitEditingJobsResponse>
    {
        public SubmitEditingJobsRequest()
            : base("Mts", "2014-06-18", "SubmitEditingJobs")
        {
        }

		private string outputBucket;

		private long? resourceOwnerId;

		private string editingJobOutputs;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string action;

		private string outputLocation;

		private long? ownerId;

		private string editingInputs;

		private string accessKeyId;

		private string pipelineId;

		public string OutputBucket
		{
			get
			{
				return outputBucket;
			}
			set	
			{
				outputBucket = value;
				DictionaryUtil.Add(QueryParameters, "OutputBucket", value);
			}
		}

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

		public string EditingJobOutputs
		{
			get
			{
				return editingJobOutputs;
			}
			set	
			{
				editingJobOutputs = value;
				DictionaryUtil.Add(QueryParameters, "EditingJobOutputs", value);
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

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
			}
		}

		public string OutputLocation
		{
			get
			{
				return outputLocation;
			}
			set	
			{
				outputLocation = value;
				DictionaryUtil.Add(QueryParameters, "OutputLocation", value);
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

		public string EditingInputs
		{
			get
			{
				return editingInputs;
			}
			set	
			{
				editingInputs = value;
				DictionaryUtil.Add(QueryParameters, "EditingInputs", value);
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
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

        public override SubmitEditingJobsResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return SubmitEditingJobsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}