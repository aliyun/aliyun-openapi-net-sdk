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

namespace Aliyun.Acs.hitsdb.Model.V20170601
{
	public class ExploreHiTSDBInstanceDataMetricListResponse : AcsResponse
	{

		private string requestId;

		private string instanceId;

		private List<ExploreHiTSDBInstanceDataMetricList_Data> metricList;

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

		public List<ExploreHiTSDBInstanceDataMetricList_Data> MetricList
		{
			get
			{
				return metricList;
			}
			set	
			{
				metricList = value;
			}
		}

		public class ExploreHiTSDBInstanceDataMetricList_Data
		{

			private string metric;

			public string Metric
			{
				get
				{
					return metric;
				}
				set	
				{
					metric = value;
				}
			}
		}
	}
}
