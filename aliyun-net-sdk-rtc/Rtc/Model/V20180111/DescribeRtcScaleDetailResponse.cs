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

namespace Aliyun.Acs.rtc.Model.V20180111
{
	public class DescribeRtcScaleDetailResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeRtcScaleDetail_ScaleItem> scale;

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

		public List<DescribeRtcScaleDetail_ScaleItem> Scale
		{
			get
			{
				return scale;
			}
			set	
			{
				scale = value;
			}
		}

		public class DescribeRtcScaleDetail_ScaleItem
		{

			private string tS;

			private long? cC;

			private long? uC;

			public string TS
			{
				get
				{
					return tS;
				}
				set	
				{
					tS = value;
				}
			}

			public long? CC
			{
				get
				{
					return cC;
				}
				set	
				{
					cC = value;
				}
			}

			public long? UC
			{
				get
				{
					return uC;
				}
				set	
				{
					uC = value;
				}
			}
		}
	}
}
