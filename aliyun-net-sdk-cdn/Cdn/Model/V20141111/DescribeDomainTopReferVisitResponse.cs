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
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Model.V20141111
{
	public class DescribeDomainTopReferVisitResponse : AcsResponse
	{

		private string requestId;

		private string domainName;

		private string startTime;

		private List<DescribeDomainTopReferVisit_ReferList> topReferList;

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

			private string referDetail;

			private string visitData;

			private float? visitProportion;

			private string flow;

			private float? flowProportion;

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
		}
	}
}