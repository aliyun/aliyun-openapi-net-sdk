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

namespace Aliyun.Acs.aegis.Model.V20161111
{
	public class DescribeStatisticsResponse : AcsResponse
	{

		private string requestId;

		private DescribeStatistics_Statistics statistics;

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

		public DescribeStatistics_Statistics Statistics
		{
			get
			{
				return statistics;
			}
			set	
			{
				statistics = value;
			}
		}

		public class DescribeStatistics_Statistics
		{

			private int? vulAsapSum;

			private int? vulNntfSum;

			private int? healthTotal;

			private int? suspiciousmediumTotal;

			private int? health;

			private int? healthdealedTotal;

			private int? trojan;

			private int? vulLaterSum;

			private int? suspicious;

			private int? vul;

			private int? healthhighTotal;

			private int? healthlowTotal;

			private int? healthseriousTotal;

			private int? vulDealedTotal;

			private int? patch;

			private int? suspicioushighTotal;

			private int? suspiciouslowTotal;

			private int? suspiciousTotal;

			private int? vulTotal;

			private int? suspiciousseriousTotal;

			private int? healthmediumTotal;

			private bool? online;

			private int? suspiciousdealedTotal;

			private int? account;

			public int? VulAsapSum
			{
				get
				{
					return vulAsapSum;
				}
				set	
				{
					vulAsapSum = value;
				}
			}

			public int? VulNntfSum
			{
				get
				{
					return vulNntfSum;
				}
				set	
				{
					vulNntfSum = value;
				}
			}

			public int? HealthTotal
			{
				get
				{
					return healthTotal;
				}
				set	
				{
					healthTotal = value;
				}
			}

			public int? SuspiciousmediumTotal
			{
				get
				{
					return suspiciousmediumTotal;
				}
				set	
				{
					suspiciousmediumTotal = value;
				}
			}

			public int? Health
			{
				get
				{
					return health;
				}
				set	
				{
					health = value;
				}
			}

			public int? HealthdealedTotal
			{
				get
				{
					return healthdealedTotal;
				}
				set	
				{
					healthdealedTotal = value;
				}
			}

			public int? Trojan
			{
				get
				{
					return trojan;
				}
				set	
				{
					trojan = value;
				}
			}

			public int? VulLaterSum
			{
				get
				{
					return vulLaterSum;
				}
				set	
				{
					vulLaterSum = value;
				}
			}

			public int? Suspicious
			{
				get
				{
					return suspicious;
				}
				set	
				{
					suspicious = value;
				}
			}

			public int? Vul
			{
				get
				{
					return vul;
				}
				set	
				{
					vul = value;
				}
			}

			public int? HealthhighTotal
			{
				get
				{
					return healthhighTotal;
				}
				set	
				{
					healthhighTotal = value;
				}
			}

			public int? HealthlowTotal
			{
				get
				{
					return healthlowTotal;
				}
				set	
				{
					healthlowTotal = value;
				}
			}

			public int? HealthseriousTotal
			{
				get
				{
					return healthseriousTotal;
				}
				set	
				{
					healthseriousTotal = value;
				}
			}

			public int? VulDealedTotal
			{
				get
				{
					return vulDealedTotal;
				}
				set	
				{
					vulDealedTotal = value;
				}
			}

			public int? Patch
			{
				get
				{
					return patch;
				}
				set	
				{
					patch = value;
				}
			}

			public int? SuspicioushighTotal
			{
				get
				{
					return suspicioushighTotal;
				}
				set	
				{
					suspicioushighTotal = value;
				}
			}

			public int? SuspiciouslowTotal
			{
				get
				{
					return suspiciouslowTotal;
				}
				set	
				{
					suspiciouslowTotal = value;
				}
			}

			public int? SuspiciousTotal
			{
				get
				{
					return suspiciousTotal;
				}
				set	
				{
					suspiciousTotal = value;
				}
			}

			public int? VulTotal
			{
				get
				{
					return vulTotal;
				}
				set	
				{
					vulTotal = value;
				}
			}

			public int? SuspiciousseriousTotal
			{
				get
				{
					return suspiciousseriousTotal;
				}
				set	
				{
					suspiciousseriousTotal = value;
				}
			}

			public int? HealthmediumTotal
			{
				get
				{
					return healthmediumTotal;
				}
				set	
				{
					healthmediumTotal = value;
				}
			}

			public bool? Online
			{
				get
				{
					return online;
				}
				set	
				{
					online = value;
				}
			}

			public int? SuspiciousdealedTotal
			{
				get
				{
					return suspiciousdealedTotal;
				}
				set	
				{
					suspiciousdealedTotal = value;
				}
			}

			public int? Account
			{
				get
				{
					return account;
				}
				set	
				{
					account = value;
				}
			}
		}
	}
}
