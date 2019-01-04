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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeProxyFunctionSupportResponse : AcsResponse
	{

		private string requestId;

		private int? isProxyEnable;

		private int? isRwsplitEnable;

		private int? isRwsplitSupportReplicationLag;

		private int? isRwsplitSupportWeight;

		private int? isTransparentSwitchEnable;

		private int? isShortConnectionOptimizeEnable;

		private int? isAntiBruteFroceEnable;

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

		public int? IsProxyEnable
		{
			get
			{
				return isProxyEnable;
			}
			set	
			{
				isProxyEnable = value;
			}
		}

		public int? IsRwsplitEnable
		{
			get
			{
				return isRwsplitEnable;
			}
			set	
			{
				isRwsplitEnable = value;
			}
		}

		public int? IsRwsplitSupportReplicationLag
		{
			get
			{
				return isRwsplitSupportReplicationLag;
			}
			set	
			{
				isRwsplitSupportReplicationLag = value;
			}
		}

		public int? IsRwsplitSupportWeight
		{
			get
			{
				return isRwsplitSupportWeight;
			}
			set	
			{
				isRwsplitSupportWeight = value;
			}
		}

		public int? IsTransparentSwitchEnable
		{
			get
			{
				return isTransparentSwitchEnable;
			}
			set	
			{
				isTransparentSwitchEnable = value;
			}
		}

		public int? IsShortConnectionOptimizeEnable
		{
			get
			{
				return isShortConnectionOptimizeEnable;
			}
			set	
			{
				isShortConnectionOptimizeEnable = value;
			}
		}

		public int? IsAntiBruteFroceEnable
		{
			get
			{
				return isAntiBruteFroceEnable;
			}
			set	
			{
				isAntiBruteFroceEnable = value;
			}
		}
	}
}