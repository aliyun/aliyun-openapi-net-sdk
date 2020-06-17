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
using Aliyun.Acs.aliyuncvc.Transform;
using Aliyun.Acs.aliyuncvc.Transform.V20200330;

namespace Aliyun.Acs.aliyuncvc.Model.V20200330
{
    public class CreateEvaluationRequest : RpcAcsRequest<CreateEvaluationResponse>
    {
        public CreateEvaluationRequest()
            : base("aliyuncvc", "2020-03-30", "CreateEvaluation", "aliyuncvc", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? createTime;

		private string memo;

		private string description;

		private string memberUUID;

		private string userId;

		private string evaluation;

		private string score;

		private string meetingUUID;

		public long? CreateTime
		{
			get
			{
				return createTime;
			}
			set	
			{
				createTime = value;
				DictionaryUtil.Add(QueryParameters, "CreateTime", value.ToString());
			}
		}

		public string Memo
		{
			get
			{
				return memo;
			}
			set	
			{
				memo = value;
				DictionaryUtil.Add(QueryParameters, "Memo", value);
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public string MemberUUID
		{
			get
			{
				return memberUUID;
			}
			set	
			{
				memberUUID = value;
				DictionaryUtil.Add(QueryParameters, "MemberUUID", value);
			}
		}

		public string UserId
		{
			get
			{
				return userId;
			}
			set	
			{
				userId = value;
				DictionaryUtil.Add(QueryParameters, "UserId", value);
			}
		}

		public string Evaluation
		{
			get
			{
				return evaluation;
			}
			set	
			{
				evaluation = value;
				DictionaryUtil.Add(QueryParameters, "Evaluation", value);
			}
		}

		public string Score
		{
			get
			{
				return score;
			}
			set	
			{
				score = value;
				DictionaryUtil.Add(QueryParameters, "Score", value);
			}
		}

		public string MeetingUUID
		{
			get
			{
				return meetingUUID;
			}
			set	
			{
				meetingUUID = value;
				DictionaryUtil.Add(QueryParameters, "MeetingUUID", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateEvaluationResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateEvaluationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
