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
using Aliyun.Acs.safconsole.Transform;
using Aliyun.Acs.safconsole.Transform.V20210112;

namespace Aliyun.Acs.safconsole.Model.V20210112
{
    public class RevokeFeedbackRequest : RpcAcsRequest<RevokeFeedbackResponse>
    {
        public RevokeFeedbackRequest()
            : base("safconsole", "2021-01-12", "RevokeFeedback", "saf", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string sampleType;

		private string _value;

		public string SampleType
		{
			get
			{
				return sampleType;
			}
			set	
			{
				sampleType = value;
				DictionaryUtil.Add(BodyParameters, "SampleType", value);
			}
		}

		public string _Value
		{
			get
			{
				return _value;
			}
			set	
			{
				_value = value;
				DictionaryUtil.Add(BodyParameters, "Value", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override RevokeFeedbackResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return RevokeFeedbackResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
