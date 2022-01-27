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
using Aliyun.Acs.ivision;
using Aliyun.Acs.ivision.Transform;
using Aliyun.Acs.ivision.Transform.V20190308;

namespace Aliyun.Acs.ivision.Model.V20190308
{
    public class CreateStreamPredictRequest : RpcAcsRequest<CreateStreamPredictResponse>
    {
        public CreateStreamPredictRequest()
            : base("ivision", "2019-03-08", "CreateStreamPredict")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.ivision.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.ivision.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string clientToken;

		private string autoStart;

		private string notify;

		private string output;

		private string streamType;

		private string faceGroupId;

		private string streamId;

		private string predictTemplateId;

		private string detectIntervals;

		private long? ownerId;

		private string probabilityThresholds;

		private string modelIds;

		private string modelUserData;

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		public string AutoStart
		{
			get
			{
				return autoStart;
			}
			set	
			{
				autoStart = value;
				DictionaryUtil.Add(QueryParameters, "AutoStart", value);
			}
		}

		public string Notify
		{
			get
			{
				return notify;
			}
			set	
			{
				notify = value;
				DictionaryUtil.Add(QueryParameters, "Notify", value);
			}
		}

		public string Output
		{
			get
			{
				return output;
			}
			set	
			{
				output = value;
				DictionaryUtil.Add(QueryParameters, "Output", value);
			}
		}

		public string StreamType
		{
			get
			{
				return streamType;
			}
			set	
			{
				streamType = value;
				DictionaryUtil.Add(QueryParameters, "StreamType", value);
			}
		}

		public string FaceGroupId
		{
			get
			{
				return faceGroupId;
			}
			set	
			{
				faceGroupId = value;
				DictionaryUtil.Add(QueryParameters, "FaceGroupId", value);
			}
		}

		public string StreamId
		{
			get
			{
				return streamId;
			}
			set	
			{
				streamId = value;
				DictionaryUtil.Add(QueryParameters, "StreamId", value);
			}
		}

		public string PredictTemplateId
		{
			get
			{
				return predictTemplateId;
			}
			set	
			{
				predictTemplateId = value;
				DictionaryUtil.Add(QueryParameters, "PredictTemplateId", value);
			}
		}

		public string DetectIntervals
		{
			get
			{
				return detectIntervals;
			}
			set	
			{
				detectIntervals = value;
				DictionaryUtil.Add(QueryParameters, "DetectIntervals", value);
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

		public string ProbabilityThresholds
		{
			get
			{
				return probabilityThresholds;
			}
			set	
			{
				probabilityThresholds = value;
				DictionaryUtil.Add(QueryParameters, "ProbabilityThresholds", value);
			}
		}

		public string ModelIds
		{
			get
			{
				return modelIds;
			}
			set	
			{
				modelIds = value;
				DictionaryUtil.Add(QueryParameters, "ModelIds", value);
			}
		}

		public string ModelUserData
		{
			get
			{
				return modelUserData;
			}
			set	
			{
				modelUserData = value;
				DictionaryUtil.Add(QueryParameters, "ModelUserData", value);
			}
		}

        public override CreateStreamPredictResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateStreamPredictResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
