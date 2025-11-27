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
using Aliyun.Acs.quickbi_public.Transform;
using Aliyun.Acs.quickbi_public.Transform.V20220101;

namespace Aliyun.Acs.quickbi_public.Model.V20220101
{
    public class DataInterpretationRequest : RpcAcsRequest<DataInterpretationResponse>
    {
        public DataInterpretationRequest()
            : base("quickbi-public", "2022-01-01", "DataInterpretation", "2.2.0", "openAPI")
        {
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private bool? promptForceOverride;

		private string data;

		private string userQuestion;

		private string userPrompt;

		private string modelCode;

		public bool? PromptForceOverride
		{
			get
			{
				return promptForceOverride;
			}
			set	
			{
				promptForceOverride = value;
				DictionaryUtil.Add(QueryParameters, "PromptForceOverride", value.ToString());
			}
		}

		public string Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
				DictionaryUtil.Add(QueryParameters, "Data", value);
			}
		}

		public string UserQuestion
		{
			get
			{
				return userQuestion;
			}
			set	
			{
				userQuestion = value;
				DictionaryUtil.Add(QueryParameters, "UserQuestion", value);
			}
		}

		public string UserPrompt
		{
			get
			{
				return userPrompt;
			}
			set	
			{
				userPrompt = value;
				DictionaryUtil.Add(QueryParameters, "UserPrompt", value);
			}
		}

		public string ModelCode
		{
			get
			{
				return modelCode;
			}
			set	
			{
				modelCode = value;
				DictionaryUtil.Add(QueryParameters, "ModelCode", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DataInterpretationResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DataInterpretationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
