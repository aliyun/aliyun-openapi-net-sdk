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
using Aliyun.Acs.EcsDemo.Transform;
using Aliyun.Acs.EcsDemo.Transform.V20190620;

namespace Aliyun.Acs.EcsDemo.Model.V20190620
{
    public class DeleteInstanceRequest : RpcAcsRequest<DeleteInstanceResponse>
    {
        public DeleteInstanceRequest()
            : base("EcsDemo", "2019-06-20", "DeleteInstance", "EcsDemo", "innerAPI")
        {
			Protocol = ProtocolType.HTTPS;
        }

		private string instanceId;

		private bool? terminateSubscription;

		private string ownerAccount;

		private string force;

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(BodyParameters, "InstanceId", value);
			}
		}

		public bool? TerminateSubscription
		{
			get
			{
				return terminateSubscription;
			}
			set	
			{
				terminateSubscription = value;
				DictionaryUtil.Add(BodyParameters, "TerminateSubscription", value.ToString());
			}
		}

		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(BodyParameters, "OwnerAccount", value);
			}
		}

		public string Force
		{
			get
			{
				return force;
			}
			set	
			{
				force = value;
				DictionaryUtil.Add(BodyParameters, "Force", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DeleteInstanceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DeleteInstanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
