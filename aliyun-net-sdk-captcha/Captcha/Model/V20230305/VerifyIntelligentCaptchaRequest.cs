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
using Aliyun.Acs.captcha;
using Aliyun.Acs.captcha.Transform;
using Aliyun.Acs.captcha.Transform.V20230305;

namespace Aliyun.Acs.captcha.Model.V20230305
{
    public class VerifyIntelligentCaptchaRequest : RpcAcsRequest<VerifyIntelligentCaptchaResponse>
    {
        public VerifyIntelligentCaptchaRequest()
            : base("captcha", "2023-03-05", "VerifyIntelligentCaptcha")
        {
			Method = MethodType.POST;
        }

		private string captchaVerifyParam;

		private string sceneId;

		public string CaptchaVerifyParam
		{
			get
			{
				return captchaVerifyParam;
			}
			set	
			{
				captchaVerifyParam = value;
				DictionaryUtil.Add(BodyParameters, "CaptchaVerifyParam", value);
			}
		}

		public string SceneId
		{
			get
			{
				return sceneId;
			}
			set	
			{
				sceneId = value;
				DictionaryUtil.Add(BodyParameters, "SceneId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override VerifyIntelligentCaptchaResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return VerifyIntelligentCaptchaResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
