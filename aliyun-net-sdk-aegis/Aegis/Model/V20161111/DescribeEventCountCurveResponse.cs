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
	public class DescribeEventCountCurveResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private DescribeEventCountCurve_CurveData curveData;

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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public DescribeEventCountCurve_CurveData CurveData
		{
			get
			{
				return curveData;
			}
			set	
			{
				curveData = value;
			}
		}

		public class DescribeEventCountCurve_CurveData
		{

			private List<DescribeEventCountCurve_Item> items;

			private DescribeEventCountCurve_TimeScope timeScope;

			public List<DescribeEventCountCurve_Item> Items
			{
				get
				{
					return items;
				}
				set	
				{
					items = value;
				}
			}

			public DescribeEventCountCurve_TimeScope TimeScope
			{
				get
				{
					return timeScope;
				}
				set	
				{
					timeScope = value;
				}
			}

			public class DescribeEventCountCurve_Item
			{

				private string name;

				private List<DescribeEventCountCurve_DataItem> data;

				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}

				public List<DescribeEventCountCurve_DataItem> Data
				{
					get
					{
						return data;
					}
					set	
					{
						data = value;
					}
				}

				public class DescribeEventCountCurve_DataItem
				{

					private int? high;

					private int? total;

					private int? low;

					private int? serious;

					private int? suspicious;

					private int? remind;

					private int? medium;

					public int? High
					{
						get
						{
							return high;
						}
						set	
						{
							high = value;
						}
					}

					public int? Total
					{
						get
						{
							return total;
						}
						set	
						{
							total = value;
						}
					}

					public int? Low
					{
						get
						{
							return low;
						}
						set	
						{
							low = value;
						}
					}

					public int? Serious
					{
						get
						{
							return serious;
						}
						set	
						{
							serious = value;
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

					public int? Remind
					{
						get
						{
							return remind;
						}
						set	
						{
							remind = value;
						}
					}

					public int? Medium
					{
						get
						{
							return medium;
						}
						set	
						{
							medium = value;
						}
					}
				}
			}

			public class DescribeEventCountCurve_TimeScope
			{

				private long? start;

				private long? end;

				private int? interval;

				private int? step;

				public long? Start
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

				public long? End
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

				public int? Interval
				{
					get
					{
						return interval;
					}
					set	
					{
						interval = value;
					}
				}

				public int? Step
				{
					get
					{
						return step;
					}
					set	
					{
						step = value;
					}
				}
			}
		}
	}
}
