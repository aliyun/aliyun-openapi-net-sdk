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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Slb.Model.V20140515;

namespace Aliyun.Acs.Slb.Transform.V20140515
{
    public class ListTLSCipherPoliciesResponseUnmarshaller
    {
        public static ListTLSCipherPoliciesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTLSCipherPoliciesResponse listTLSCipherPoliciesResponse = new ListTLSCipherPoliciesResponse();

			listTLSCipherPoliciesResponse.HttpResponse = _ctx.HttpResponse;
			listTLSCipherPoliciesResponse.RequestId = _ctx.StringValue("ListTLSCipherPolicies.RequestId");
			listTLSCipherPoliciesResponse.NextToken = _ctx.StringValue("ListTLSCipherPolicies.NextToken");
			listTLSCipherPoliciesResponse.IsTruncated = _ctx.BooleanValue("ListTLSCipherPolicies.IsTruncated");
			listTLSCipherPoliciesResponse.TotalCount = _ctx.IntegerValue("ListTLSCipherPolicies.TotalCount");

			List<ListTLSCipherPoliciesResponse.ListTLSCipherPolicies_TLSCipherPolicy> listTLSCipherPoliciesResponse_tLSCipherPolicies = new List<ListTLSCipherPoliciesResponse.ListTLSCipherPolicies_TLSCipherPolicy>();
			for (int i = 0; i < _ctx.Length("ListTLSCipherPolicies.TLSCipherPolicies.Length"); i++) {
				ListTLSCipherPoliciesResponse.ListTLSCipherPolicies_TLSCipherPolicy tLSCipherPolicy = new ListTLSCipherPoliciesResponse.ListTLSCipherPolicies_TLSCipherPolicy();
				tLSCipherPolicy.CreateTime = _ctx.LongValue("ListTLSCipherPolicies.TLSCipherPolicies["+ i +"].CreateTime");
				tLSCipherPolicy.InstanceId = _ctx.StringValue("ListTLSCipherPolicies.TLSCipherPolicies["+ i +"].InstanceId");
				tLSCipherPolicy.Name = _ctx.StringValue("ListTLSCipherPolicies.TLSCipherPolicies["+ i +"].Name");
				tLSCipherPolicy.Status = _ctx.StringValue("ListTLSCipherPolicies.TLSCipherPolicies["+ i +"].Status");

				List<string> tLSCipherPolicy_tLSVersions = new List<string>();
				for (int j = 0; j < _ctx.Length("ListTLSCipherPolicies.TLSCipherPolicies["+ i +"].TLSVersions.Length"); j++) {
					tLSCipherPolicy_tLSVersions.Add(_ctx.StringValue("ListTLSCipherPolicies.TLSCipherPolicies["+ i +"].TLSVersions["+ j +"]"));
				}
				tLSCipherPolicy.TLSVersions = tLSCipherPolicy_tLSVersions;

				List<string> tLSCipherPolicy_ciphers = new List<string>();
				for (int j = 0; j < _ctx.Length("ListTLSCipherPolicies.TLSCipherPolicies["+ i +"].Ciphers.Length"); j++) {
					tLSCipherPolicy_ciphers.Add(_ctx.StringValue("ListTLSCipherPolicies.TLSCipherPolicies["+ i +"].Ciphers["+ j +"]"));
				}
				tLSCipherPolicy.Ciphers = tLSCipherPolicy_ciphers;

				List<ListTLSCipherPoliciesResponse.ListTLSCipherPolicies_TLSCipherPolicy.ListTLSCipherPolicies_RelateListener> tLSCipherPolicy_relateListeners = new List<ListTLSCipherPoliciesResponse.ListTLSCipherPolicies_TLSCipherPolicy.ListTLSCipherPolicies_RelateListener>();
				for (int j = 0; j < _ctx.Length("ListTLSCipherPolicies.TLSCipherPolicies["+ i +"].RelateListeners.Length"); j++) {
					ListTLSCipherPoliciesResponse.ListTLSCipherPolicies_TLSCipherPolicy.ListTLSCipherPolicies_RelateListener relateListener = new ListTLSCipherPoliciesResponse.ListTLSCipherPolicies_TLSCipherPolicy.ListTLSCipherPolicies_RelateListener();
					relateListener.LoadBalancerId = _ctx.StringValue("ListTLSCipherPolicies.TLSCipherPolicies["+ i +"].RelateListeners["+ j +"].LoadBalancerId");
					relateListener.Port = _ctx.IntegerValue("ListTLSCipherPolicies.TLSCipherPolicies["+ i +"].RelateListeners["+ j +"].Port");
					relateListener.Protocol = _ctx.StringValue("ListTLSCipherPolicies.TLSCipherPolicies["+ i +"].RelateListeners["+ j +"].Protocol");

					tLSCipherPolicy_relateListeners.Add(relateListener);
				}
				tLSCipherPolicy.RelateListeners = tLSCipherPolicy_relateListeners;

				listTLSCipherPoliciesResponse_tLSCipherPolicies.Add(tLSCipherPolicy);
			}
			listTLSCipherPoliciesResponse.TLSCipherPolicies = listTLSCipherPoliciesResponse_tLSCipherPolicies;
        
			return listTLSCipherPoliciesResponse;
        }
    }
}
