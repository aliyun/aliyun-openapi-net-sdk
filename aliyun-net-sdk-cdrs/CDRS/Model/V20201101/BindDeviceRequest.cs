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
using Aliyun.Acs.CDRS;
using Aliyun.Acs.CDRS.Transform;
using Aliyun.Acs.CDRS.Transform.V20201101;

namespace Aliyun.Acs.CDRS.Model.V20201101
{
    public class BindDeviceRequest : RpcAcsRequest<BindDeviceResponse>
    {
        public BindDeviceRequest()
            : base("CDRS", "2020-11-01", "BindDevice")
        {
			Method = MethodType.POST;
        }

		private string corpId;

		private List<Devices> devicess = new List<Devices>(){ };

		public string CorpId
		{
			get
			{
				return corpId;
			}
			set	
			{
				corpId = value;
				DictionaryUtil.Add(BodyParameters, "CorpId", value);
			}
		}

		public List<Devices> Devicess
		{
			get
			{
				return devicess;
			}

			set
			{
				devicess = value;
				for (int i = 0; i < devicess.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"Devices." + (i + 1) + ".CorpId", devicess[i].CorpId);
					DictionaryUtil.Add(BodyParameters,"Devices." + (i + 1) + ".DeviceId", devicess[i].DeviceId);
				}
			}
		}

		public class Devices
		{

			private string corpId;

			private string deviceId;

			public string CorpId
			{
				get
				{
					return corpId;
				}
				set	
				{
					corpId = value;
				}
			}

			public string DeviceId
			{
				get
				{
					return deviceId;
				}
				set	
				{
					deviceId = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override BindDeviceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return BindDeviceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
