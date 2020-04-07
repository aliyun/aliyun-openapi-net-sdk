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
    public class SubmitComplexJobRequest : RpcAcsRequest<SubmitComplexJobResponse>
    {
        public SubmitComplexJobRequest()
            : base("Mts", "2014-06-18", "SubmitComplexJob", "mts", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private long? resourceOwnerId;

		private string transcodeOutput;

		private string inputs;

		private string outputLocation;

		private string userData;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private string pipelineId;

		private string outputBucket;

		private string complexConfigs;

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

		public string TranscodeOutput
		{
			get
			{
				return transcodeOutput;
			}
			set	
			{
				transcodeOutput = value;
				DictionaryUtil.Add(QueryParameters, "TranscodeOutput", value);
			}
		}

		public string Inputs
		{
			get
			{
				return inputs;
			}
			set	
			{
				inputs = value;
				DictionaryUtil.Add(QueryParameters, "Inputs", value);
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

		public string ComplexConfigs
		{
			get
			{
				return complexConfigs;
			}
			set	
			{
				complexConfigs = value;
				DictionaryUtil.Add(QueryParameters, "ComplexConfigs", value);
			}
		}

        public override SubmitComplexJobResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SubmitComplexJobResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
