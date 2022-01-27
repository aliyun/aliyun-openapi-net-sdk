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
using Aliyun.Acs.OutboundBot.Transform;
using Aliyun.Acs.OutboundBot.Transform.V20191226;

namespace Aliyun.Acs.OutboundBot.Model.V20191226
{
    public class CreateGlobalQuestionRequest : RpcAcsRequest<CreateGlobalQuestionResponse>
    {
        public CreateGlobalQuestionRequest()
            : base("OutboundBot", "2019-12-26", "CreateGlobalQuestion", "outboundbot", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.OutboundBot.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.OutboundBot.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string globalQuestionName;

		private string questions;

		private string answers;

		private string scriptId;

		private string instanceId;

		private string globalQuestionType;

		public string GlobalQuestionName
		{
			get
			{
				return globalQuestionName;
			}
			set	
			{
				globalQuestionName = value;
				DictionaryUtil.Add(QueryParameters, "GlobalQuestionName", value);
			}
		}

		public string Questions
		{
			get
			{
				return questions;
			}
			set	
			{
				questions = value;
				DictionaryUtil.Add(QueryParameters, "Questions", value);
			}
		}

		public string Answers
		{
			get
			{
				return answers;
			}
			set	
			{
				answers = value;
				DictionaryUtil.Add(QueryParameters, "Answers", value);
			}
		}

		public string ScriptId
		{
			get
			{
				return scriptId;
			}
			set	
			{
				scriptId = value;
				DictionaryUtil.Add(QueryParameters, "ScriptId", value);
			}
		}

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public string GlobalQuestionType
		{
			get
			{
				return globalQuestionType;
			}
			set	
			{
				globalQuestionType = value;
				DictionaryUtil.Add(QueryParameters, "GlobalQuestionType", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateGlobalQuestionResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateGlobalQuestionResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
