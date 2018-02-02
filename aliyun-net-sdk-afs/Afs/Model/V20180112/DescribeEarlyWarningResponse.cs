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

namespace Aliyun.Acs.afs.Model.V20180112
{
	public class DescribeEarlyWarningResponse : AcsResponse
	{

		private string requestId;

		private bool? hasWarning;

		private string bizCode;

		private List<DescribeEarlyWarning_EarlyWarning> earlyWarnings;

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

		public bool? HasWarning
		{
			get
			{
				return hasWarning;
			}
			set	
			{
				hasWarning = value;
			}
		}

		public string BizCode
		{
			get
			{
				return bizCode;
			}
			set	
			{
				bizCode = value;
			}
		}

		public List<DescribeEarlyWarning_EarlyWarning> EarlyWarnings
		{
			get
			{
				return earlyWarnings;
			}
			set	
			{
				earlyWarnings = value;
			}
		}

		public class DescribeEarlyWarning_EarlyWarning
		{

			private bool? warnOpen;

			private string title;

			private string content;

			private string frequency;

			private bool? timeOpen;

			private string timeBegin;

			private string timeEnd;

			private string channel;

			public bool? WarnOpen
			{
				get
				{
					return warnOpen;
				}
				set	
				{
					warnOpen = value;
				}
			}

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

			public string Content
			{
				get
				{
					return content;
				}
				set	
				{
					content = value;
				}
			}

			public string Frequency
			{
				get
				{
					return frequency;
				}
				set	
				{
					frequency = value;
				}
			}

			public bool? TimeOpen
			{
				get
				{
					return timeOpen;
				}
				set	
				{
					timeOpen = value;
				}
			}

			public string TimeBegin
			{
				get
				{
					return timeBegin;
				}
				set	
				{
					timeBegin = value;
				}
			}

			public string TimeEnd
			{
				get
				{
					return timeEnd;
				}
				set	
				{
					timeEnd = value;
				}
			}

			public string Channel
			{
				get
				{
					return channel;
				}
				set	
				{
					channel = value;
				}
			}
		}
	}
}