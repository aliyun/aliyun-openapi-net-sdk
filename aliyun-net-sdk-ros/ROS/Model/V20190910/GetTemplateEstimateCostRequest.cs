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
using Aliyun.Acs.ROS.Transform;
using Aliyun.Acs.ROS.Transform.V20190910;

namespace Aliyun.Acs.ROS.Model.V20190910
{
    public class GetTemplateEstimateCostRequest : RpcAcsRequest<GetTemplateEstimateCostResponse>
    {
        public GetTemplateEstimateCostRequest()
            : base("ROS", "2019-09-10", "GetTemplateEstimateCost", "ROS", "openAPI")
        {
        }

		private string clientToken;

		private string templateBody;

		private List<Parameters> parameterss = new List<Parameters>(){ };

		private string templateURL;

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

		public string TemplateBody
		{
			get
			{
				return templateBody;
			}
			set	
			{
				templateBody = value;
				DictionaryUtil.Add(QueryParameters, "TemplateBody", value);
			}
		}

		public List<Parameters> Parameterss
		{
			get
			{
				return parameterss;
			}

			set
			{
				parameterss = value;
				for (int i = 0; i < parameterss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Parameters." + (i + 1) + ".ParameterValue", parameterss[i].ParameterValue);
					DictionaryUtil.Add(QueryParameters,"Parameters." + (i + 1) + ".ParameterKey", parameterss[i].ParameterKey);
				}
			}
		}

		public string TemplateURL
		{
			get
			{
				return templateURL;
			}
			set	
			{
				templateURL = value;
				DictionaryUtil.Add(QueryParameters, "TemplateURL", value);
			}
		}

		public class Parameters
		{

			private string parameterValue;

			private string parameterKey;

			public string ParameterValue
			{
				get
				{
					return parameterValue;
				}
				set	
				{
					parameterValue = value;
				}
			}

			public string ParameterKey
			{
				get
				{
					return parameterKey;
				}
				set	
				{
					parameterKey = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetTemplateEstimateCostResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetTemplateEstimateCostResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
