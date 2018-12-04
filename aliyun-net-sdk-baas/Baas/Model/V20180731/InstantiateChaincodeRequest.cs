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
using Aliyun.Acs.Baas.Transform;
using Aliyun.Acs.Baas.Transform.V20180731;
using System.Collections.Generic;

namespace Aliyun.Acs.Baas.Model.V20180731
{
    public class InstantiateChaincodeRequest : RpcAcsRequest<InstantiateChaincodeResponse>
    {
        public InstantiateChaincodeRequest()
            : base("Baas", "2018-07-31", "InstantiateChaincode")
        {
        }

		private string organizationId;

		private string chaincodeId;

		private string endorsePolicy;

		private string location;

		public string OrganizationId
		{
			get
			{
				return organizationId;
			}
			set	
			{
				organizationId = value;
				DictionaryUtil.Add(BodyParameters, "OrganizationId", value);
			}
		}

		public string ChaincodeId
		{
			get
			{
				return chaincodeId;
			}
			set	
			{
				chaincodeId = value;
				DictionaryUtil.Add(BodyParameters, "ChaincodeId", value);
			}
		}

		public string EndorsePolicy
		{
			get
			{
				return endorsePolicy;
			}
			set	
			{
				endorsePolicy = value;
				DictionaryUtil.Add(BodyParameters, "EndorsePolicy", value);
			}
		}

		public string Location
		{
			get
			{
				return location;
			}
			set	
			{
				location = value;
				DictionaryUtil.Add(BodyParameters, "Location", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override InstantiateChaincodeResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return InstantiateChaincodeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}