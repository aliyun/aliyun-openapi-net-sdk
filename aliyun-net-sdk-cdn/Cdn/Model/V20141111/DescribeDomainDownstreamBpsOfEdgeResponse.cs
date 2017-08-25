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
	public class DescribeDomainDownstreamBpsOfEdgeResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeDomainDownstreamBpsOfEdge_DomainBpsModel> bpsDatas;

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

		public List<DescribeDomainDownstreamBpsOfEdge_DomainBpsModel> BpsDatas
		{
			get
			{
				return bpsDatas;
			}
			set	
			{
				bpsDatas = value;
			}
		}

		public class DescribeDomainDownstreamBpsOfEdge_DomainBpsModel
		{

			private string time;

			private float? bps;

			public string Time
			{
				get
				{
					return time;
				}
				set	
				{
					time = value;
				}
			}

			public float? Bps
			{
				get
				{
					return bps;
				}
				set	
				{
					bps = value;
				}
			}
		}
	}
}