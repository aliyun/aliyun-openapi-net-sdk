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
using Aliyun.Acs.EduInterpreting;
using Aliyun.Acs.EduInterpreting.Transform;
using Aliyun.Acs.EduInterpreting.Transform.V20240828;

namespace Aliyun.Acs.EduInterpreting.Model.V20240828
{
    public class SubmitEvaluationTaskRequest : RpcAcsRequest<SubmitEvaluationTaskResponse>
    {
        public SubmitEvaluationTaskRequest()
            : base("EduInterpreting", "2024-08-28", "SubmitEvaluationTask")
        {
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string materialText;

		private string suggestedAnswer;

		private string outerBizId;

		private string type;

		private string audioUrl;

		private string text;

		private string callbackUrl;

		public string MaterialText
		{
			get
			{
				return materialText;
			}
			set	
			{
				materialText = value;
				DictionaryUtil.Add(BodyParameters, "MaterialText", value);
			}
		}

		public string SuggestedAnswer
		{
			get
			{
				return suggestedAnswer;
			}
			set	
			{
				suggestedAnswer = value;
				DictionaryUtil.Add(BodyParameters, "SuggestedAnswer", value);
			}
		}

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

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(BodyParameters, "Type", value);
			}
		}

		public string AudioUrl
		{
			get
			{
				return audioUrl;
			}
			set	
			{
				audioUrl = value;
				DictionaryUtil.Add(BodyParameters, "AudioUrl", value);
			}
		}

		public string Text
		{
			get
			{
				return text;
			}
			set	
			{
				text = value;
				DictionaryUtil.Add(BodyParameters, "Text", value);
			}
		}

		public string CallbackUrl
		{
			get
			{
				return callbackUrl;
			}
			set	
			{
				callbackUrl = value;
				DictionaryUtil.Add(BodyParameters, "CallbackUrl", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SubmitEvaluationTaskResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SubmitEvaluationTaskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
