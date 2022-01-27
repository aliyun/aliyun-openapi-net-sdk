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
	public class ExploreHiTSDBInstanceDataResponse : AcsResponse
	{

		private string requestId;

		private string start;

		private string end;

		private string metric;

		private List<ExploreHiTSDBInstanceData_TimeLine> timeLines;

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

		public string Start
		{
			get
			{
				return start;
			}
			set	
			{
				start = value;
			}
		}

		public string End
		{
			get
			{
				return end;
			}
			set	
			{
				end = value;
			}
		}

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

		public List<ExploreHiTSDBInstanceData_TimeLine> TimeLines
		{
			get
			{
				return timeLines;
			}
			set	
			{
				timeLines = value;
			}
		}

		public class ExploreHiTSDBInstanceData_TimeLine
		{

			private List<ExploreHiTSDBInstanceData_Tag> tags;

			private List<ExploreHiTSDBInstanceData_Point> series;

			public List<ExploreHiTSDBInstanceData_Tag> Tags
			{
				get
				{
					return tags;
				}
				set	
				{
					tags = value;
				}
			}

			public List<ExploreHiTSDBInstanceData_Point> Series
			{
				get
				{
					return series;
				}
				set	
				{
					series = value;
				}
			}

			public class ExploreHiTSDBInstanceData_Tag
			{

				private string tagKey;

				private string tagValue;

				public string TagKey
				{
					get
					{
						return tagKey;
					}
					set	
					{
						tagKey = value;
					}
				}

				public string TagValue
				{
					get
					{
						return tagValue;
					}
					set	
					{
						tagValue = value;
					}
				}
			}

			public class ExploreHiTSDBInstanceData_Point
			{

				private string timestamp;

				private float? _value;

				public string Timestamp
				{
					get
					{
						return timestamp;
					}
					set	
					{
						timestamp = value;
					}
				}

				public float? _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}
			}
		}
	}
}
