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
using Aliyun.Acs.Chatbot.Transform;
using Aliyun.Acs.Chatbot.Transform.V20171011;
using System.Collections.Generic;

namespace Aliyun.Acs.Chatbot.Model.V20171011
{
    public class DeleteIntentRequest : RpcAcsRequest<DeleteIntentResponse>
    {
        public DeleteIntentRequest()
            : base("Chatbot", "2017-10-11", "DeleteIntent", "beebot", "openAPI")
        {
        }

		private long? intentId;

		public long? IntentId
		{
			get
			{
				return intentId;
			}
			set	
			{
				intentId = value;
				DictionaryUtil.Add(QueryParameters, "IntentId", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DeleteIntentResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DeleteIntentResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}