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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.MoPen.Transform;
using Aliyun.Acs.MoPen.Transform.V20180211;
using System.Collections.Generic;

namespace Aliyun.Acs.MoPen.Model.V20180211
{
    public class MoPenBindIsvRequest : RpcAcsRequest<MoPenBindIsvResponse>
    {
        public MoPenBindIsvRequest()
            : base("MoPen", "2018-02-11", "MoPenBindIsv")
        {
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string orderKey;

		private string deviceName;

		public string OrderKey
		{
			get
			{
				return orderKey;
			}
			set	
			{
				orderKey = value;
				DictionaryUtil.Add(BodyParameters, "OrderKey", value);
			}
		}

		public string DeviceName
		{
			get
			{
				return deviceName;
			}
			set	
			{
				deviceName = value;
				DictionaryUtil.Add(BodyParameters, "DeviceName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override MoPenBindIsvResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return MoPenBindIsvResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}