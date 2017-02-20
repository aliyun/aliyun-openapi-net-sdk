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
	public class DescribeHistoryCharge95InfoResponse : AcsResponse
	{
	    public long? PageNumber { get; set; }

	    public long? PageSize { get; set; }

	    public long? TotalCount { get; set; }

	    public long? TotalPages { get; set; }

	    public string UserName { get; set; }

	    public List<HistoryCharge95Info> HistoryCharge95Infos { get; set; }

	    public class HistoryCharge95Info{
	        public string DomainName { get; set; }

	        public string BillTime { get; set; }

	        public string ChargeItem { get; set; }

	        public long? Max95Bps { get; set; }

	        public string Max95BpsTime { get; set; }

	        public float? EffectiveFactor { get; set; }

	        public string StartTime { get; set; }

	        public string EndTime { get; set; }

	        public float? Proportion { get; set; }

	        public string DownloadUrl { get; set; }
	    }
	}
}