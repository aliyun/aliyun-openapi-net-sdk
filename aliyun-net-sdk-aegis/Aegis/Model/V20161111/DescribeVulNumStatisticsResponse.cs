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
	public class DescribeVulNumStatisticsResponse : AcsResponse
	{

		private string requestId;

		private int? cveNum;

		private int? emgNum;

		private int? sysNum;

		private int? cmsNum;

		private int? cmsDealedTotalNum;

		private int? vulDealedTotalNum;

		private int? vulAsapSum;

		private int? vulLaterSum;

		private int? vulNntfSum;

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

		public int? CveNum
		{
			get
			{
				return cveNum;
			}
			set	
			{
				cveNum = value;
			}
		}

		public int? EmgNum
		{
			get
			{
				return emgNum;
			}
			set	
			{
				emgNum = value;
			}
		}

		public int? SysNum
		{
			get
			{
				return sysNum;
			}
			set	
			{
				sysNum = value;
			}
		}

		public int? CmsNum
		{
			get
			{
				return cmsNum;
			}
			set	
			{
				cmsNum = value;
			}
		}

		public int? CmsDealedTotalNum
		{
			get
			{
				return cmsDealedTotalNum;
			}
			set	
			{
				cmsDealedTotalNum = value;
			}
		}

		public int? VulDealedTotalNum
		{
			get
			{
				return vulDealedTotalNum;
			}
			set	
			{
				vulDealedTotalNum = value;
			}
		}

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
	}
}
