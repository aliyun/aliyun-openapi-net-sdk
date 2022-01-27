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

namespace Aliyun.Acs.Vpc.Model.V20160428
{
	public class CreateTrafficMirrorFilterRulesResponse : AcsResponse
	{

		private string requestId;

		private List<CreateTrafficMirrorFilterRules_IngressRule> ingressRules;

		private List<CreateTrafficMirrorFilterRules_EgressRule> egressRules;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public List<CreateTrafficMirrorFilterRules_IngressRule> IngressRules
		{
			get
			{
				return ingressRules;
			}
			set	
			{
				ingressRules = value;
			}
		}

		public List<CreateTrafficMirrorFilterRules_EgressRule> EgressRules
		{
			get
			{
				return egressRules;
			}
			set	
			{
				egressRules = value;
			}
		}

		public class CreateTrafficMirrorFilterRules_IngressRule
		{

			private string instanceId;

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}
		}

		public class CreateTrafficMirrorFilterRules_EgressRule
		{

			private string instanceId;

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}
		}
	}
}
