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
using Aliyun.Acs.AIMath;
using Aliyun.Acs.AIMath.Transform;
using Aliyun.Acs.AIMath.Transform.V20241114;

namespace Aliyun.Acs.AIMath.Model.V20241114
{
    public class CreateRelatedConversationRequest : RpcAcsRequest<CreateRelatedConversationResponse>
    {
        public CreateRelatedConversationRequest()
            : base("AIMath", "2024-11-14", "CreateRelatedConversation")
        {
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string outerBizId;

		private string userId;

		private string exerciseCode;

		public string OuterBizId
		{
			get
			{
				return outerBizId;
			}
			set	
			{
				outerBizId = value;
				DictionaryUtil.Add(BodyParameters, "OuterBizId", value);
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
				DictionaryUtil.Add(BodyParameters, "UserId", value);
			}
		}

		public string ExerciseCode
		{
			get
			{
				return exerciseCode;
			}
			set	
			{
				exerciseCode = value;
				DictionaryUtil.Add(BodyParameters, "ExerciseCode", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateRelatedConversationResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateRelatedConversationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
