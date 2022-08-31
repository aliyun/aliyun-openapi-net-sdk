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

namespace Aliyun.Acs.Cdn.Model.V20180510
{
	public class DescribeDomainTopReferVisitResponse : AcsResponse
	{

		private string startTime;

		private string requestId;

		private string domainName;

		private List<DescribeDomainTopReferVisit_ReferList> topReferList;

		public string StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
			}
		}

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

		public string DomainName
		{
			get
			{
				return domainName;
			}
			set	
			{
				domainName = value;
			}
		}

		public List<DescribeDomainTopReferVisit_ReferList> TopReferList
		{
			get
			{
				return topReferList;
			}
			set	
			{
				topReferList = value;
			}
		}

		public class DescribeDomainTopReferVisit_ReferList
		{

			private string flow;

			private float? flowProportion;

			private string visitData;

			private string referDetail;

			private float? visitProportion;

			public string Flow
			{
				get
				{
					return flow;
				}
				set	
				{
					flow = value;
				}
			}

			public float? FlowProportion
			{
				get
				{
					return flowProportion;
				}
				set	
				{
					flowProportion = value;
				}
			}

			public string VisitData
			{
				get
				{
					return visitData;
				}
				set	
				{
					visitData = value;
				}
			}

			public string ReferDetail
			{
				get
				{
					return referDetail;
				}
				set	
				{
					referDetail = value;
				}
			}

			public float? VisitProportion
			{
				get
				{
					return visitProportion;
				}
				set	
				{
					visitProportion = value;
				}
			}
		}
	}
}
