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
	public class DescribeIpInfoResponse : AcsResponse
	{

		private string requestId;

		private string cdnIp;

		private string iSP;

		private string ispEname;

		private string region;

		private string regionEname;

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

		public string CdnIp
		{
			get
			{
				return cdnIp;
			}
			set	
			{
				cdnIp = value;
			}
		}

		public string ISP
		{
			get
			{
				return iSP;
			}
			set	
			{
				iSP = value;
			}
		}

		public string IspEname
		{
			get
			{
				return ispEname;
			}
			set	
			{
				ispEname = value;
			}
		}

		public string Region
		{
			get
			{
				return region;
			}
			set	
			{
				region = value;
			}
		}

		public string RegionEname
		{
			get
			{
				return regionEname;
			}
			set	
			{
				regionEname = value;
			}
		}
	}
}