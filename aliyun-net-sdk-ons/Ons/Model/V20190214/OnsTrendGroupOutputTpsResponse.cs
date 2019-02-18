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

namespace Aliyun.Acs.Ons.Model.V20190214
{
	public class OnsTrendGroupOutputTpsResponse : AcsResponse
	{

		private string requestId;

		private string helpUrl;

		private OnsTrendGroupOutputTps_Data data;

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

		public string HelpUrl
		{
			get
			{
				return helpUrl;
			}
			set	
			{
				helpUrl = value;
			}
		}

		public OnsTrendGroupOutputTps_Data Data
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

		public class OnsTrendGroupOutputTps_Data
		{

			private string title;

			private string xUnit;

			private string yUnit;

			private List<OnsTrendGroupOutputTps_StatsDataDo> records;

			public string Title
			{
				get
				{
					return title;
				}
				set	
				{
					title = value;
				}
			}

			public string XUnit
			{
				get
				{
					return xUnit;
				}
				set	
				{
					xUnit = value;
				}
			}

			public string YUnit
			{
				get
				{
					return yUnit;
				}
				set	
				{
					yUnit = value;
				}
			}

			public List<OnsTrendGroupOutputTps_StatsDataDo> Records
			{
				get
				{
					return records;
				}
				set	
				{
					records = value;
				}
			}

			public class OnsTrendGroupOutputTps_StatsDataDo
			{

				private long? x;

				private float? y;

				public long? X
				{
					get
					{
						return x;
					}
					set	
					{
						x = value;
					}
				}

				public float? Y
				{
					get
					{
						return y;
					}
					set	
					{
						y = value;
					}
				}
			}
		}
	}
}