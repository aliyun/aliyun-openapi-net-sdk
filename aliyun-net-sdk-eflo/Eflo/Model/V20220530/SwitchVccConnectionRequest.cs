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
using Aliyun.Acs.eflo.Transform;
using Aliyun.Acs.eflo.Transform.V20220530;

namespace Aliyun.Acs.eflo.Model.V20220530
{
    public class SwitchVccConnectionRequest : RpcAcsRequest<SwitchVccConnectionResponse>
    {
        public SwitchVccConnectionRequest()
            : base("eflo", "2022-05-30", "SwitchVccConnection", "eflo", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string cenId;

		private string vccId;

		private string connectionType;

		private string vSwitchId;

		private string vpcId;

		public string CenId
		{
			get
			{
				return cenId;
			}
			set	
			{
				cenId = value;
				DictionaryUtil.Add(BodyParameters, "CenId", value);
			}
		}

		public string VccId
		{
			get
			{
				return vccId;
			}
			set	
			{
				vccId = value;
				DictionaryUtil.Add(BodyParameters, "VccId", value);
			}
		}

		public string ConnectionType
		{
			get
			{
				return connectionType;
			}
			set	
			{
				connectionType = value;
				DictionaryUtil.Add(BodyParameters, "ConnectionType", value);
			}
		}

		public string VSwitchId
		{
			get
			{
				return vSwitchId;
			}
			set	
			{
				vSwitchId = value;
				DictionaryUtil.Add(BodyParameters, "VSwitchId", value);
			}
		}

		public string VpcId
		{
			get
			{
				return vpcId;
			}
			set	
			{
				vpcId = value;
				DictionaryUtil.Add(BodyParameters, "VpcId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SwitchVccConnectionResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SwitchVccConnectionResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
