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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.nlp_automl.Transform;
using Aliyun.Acs.nlp_automl.Transform.V20191111;

namespace Aliyun.Acs.nlp_automl.Model.V20191111
{
    public class RunPreTrainServiceRequest : RpcAcsRequest<RunPreTrainServiceResponse>
    {
        public RunPreTrainServiceRequest()
            : base("nlp-automl", "2019-11-11", "RunPreTrainService", "nlpautoml", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.nlp_automl.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.nlp_automl.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string predictContent;

		private string serviceVersion;

		private string serviceName;

		public string PredictContent
		{
			get
			{
				return predictContent;
			}
			set	
			{
				predictContent = value;
				DictionaryUtil.Add(BodyParameters, "PredictContent", value);
			}
		}

		public string ServiceVersion
		{
			get
			{
				return serviceVersion;
			}
			set	
			{
				serviceVersion = value;
				DictionaryUtil.Add(BodyParameters, "ServiceVersion", value);
			}
		}

		public string ServiceName
		{
			get
			{
				return serviceName;
			}
			set	
			{
				serviceName = value;
				DictionaryUtil.Add(BodyParameters, "ServiceName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override RunPreTrainServiceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return RunPreTrainServiceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
