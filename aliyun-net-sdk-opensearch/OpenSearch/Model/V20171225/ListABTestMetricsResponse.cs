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

namespace Aliyun.Acs.OpenSearch.Model.V20171225
{
	public class ListABTestMetricsResponse : AcsResponse
	{

		private string requestId;

		private List<ListABTestMetrics_ResultItem> result;

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

		public List<ListABTestMetrics_ResultItem> Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class ListABTestMetrics_ResultItem
		{

			private string experimentName;

			private string date;

			private int? pv;

			private int? ipv;

			private int? uv;

			private int? ipvUv;

			private float? ctr;

			private float? zeroHitRate;

			public string ExperimentName
			{
				get
				{
					return experimentName;
				}
				set	
				{
					experimentName = value;
				}
			}

			public string Date
			{
				get
				{
					return date;
				}
				set	
				{
					date = value;
				}
			}

			public int? Pv
			{
				get
				{
					return pv;
				}
				set	
				{
					pv = value;
				}
			}

			public int? Ipv
			{
				get
				{
					return ipv;
				}
				set	
				{
					ipv = value;
				}
			}

			public int? Uv
			{
				get
				{
					return uv;
				}
				set	
				{
					uv = value;
				}
			}

			public int? IpvUv
			{
				get
				{
					return ipvUv;
				}
				set	
				{
					ipvUv = value;
				}
			}

			public float? Ctr
			{
				get
				{
					return ctr;
				}
				set	
				{
					ctr = value;
				}
			}

			public float? ZeroHitRate
			{
				get
				{
					return zeroHitRate;
				}
				set	
				{
					zeroHitRate = value;
				}
			}
		}
	}
}
