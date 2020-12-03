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
using Aliyun.Acs.Iot.Transform;
using Aliyun.Acs.Iot.Transform.V20180120;

namespace Aliyun.Acs.Iot.Model.V20180120
{
    public class PushSpeechModelToDeviceRequest : RpcAcsRequest<PushSpeechModelToDeviceResponse>
    {
        public PushSpeechModelToDeviceRequest()
            : base("Iot", "2018-01-20", "PushSpeechModelToDevice", "iot", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Iot.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Iot.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string projectCode;

		private string iotId;

		private string pushMode;

		private List<string> speechModelCodeLists = new List<string>(){ };

		public string ProjectCode
		{
			get
			{
				return projectCode;
			}
			set	
			{
				projectCode = value;
				DictionaryUtil.Add(BodyParameters, "ProjectCode", value);
			}
		}

		public string IotId
		{
			get
			{
				return iotId;
			}
			set	
			{
				iotId = value;
				DictionaryUtil.Add(BodyParameters, "IotId", value);
			}
		}

		public string PushMode
		{
			get
			{
				return pushMode;
			}
			set	
			{
				pushMode = value;
				DictionaryUtil.Add(BodyParameters, "PushMode", value);
			}
		}

		public List<string> SpeechModelCodeLists
		{
			get
			{
				return speechModelCodeLists;
			}

			set
			{
				speechModelCodeLists = value;
				for (int i = 0; i < speechModelCodeLists.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"SpeechModelCodeList." + (i + 1) , speechModelCodeLists[i]);
				}
			}
		}

        public override PushSpeechModelToDeviceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return PushSpeechModelToDeviceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
