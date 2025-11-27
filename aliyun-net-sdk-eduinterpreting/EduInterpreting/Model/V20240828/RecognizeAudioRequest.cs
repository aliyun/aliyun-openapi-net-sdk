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
    public class RecognizeAudioRequest : RpcAcsRequest<RecognizeAudioResponse>
    {
        public RecognizeAudioRequest()
            : base("EduInterpreting", "2024-08-28", "RecognizeAudio")
        {
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string outerBizId;

		private bool? enableCallBack;

		private string callbackUrl;

		private string audioFileUrl;

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

		public bool? EnableCallBack
		{
			get
			{
				return enableCallBack;
			}
			set	
			{
				enableCallBack = value;
				DictionaryUtil.Add(QueryParameters, "EnableCallBack", value.ToString());
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

		public string AudioFileUrl
		{
			get
			{
				return audioFileUrl;
			}
			set	
			{
				audioFileUrl = value;
				DictionaryUtil.Add(BodyParameters, "AudioFileUrl", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override RecognizeAudioResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return RecognizeAudioResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
