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
	public class DescribeDomainRegionDataResponse : AcsResponse
	{
	    public string DomainName { get; set; }

	    public string DataInterval { get; set; }

	    public string StartTime { get; set; }

	    public string EndTime { get; set; }

	    public List<RegionProportionData> Value { get; set; }

	    public class RegionProportionData{
	        public string Region { get; set; }

	        public string Proportion { get; set; }

	        public string RegionEname { get; set; }

	        public string AvgObjectSize { get; set; }

	        public string AvgResponseTime { get; set; }

	        public string Bps { get; set; }

	        public string ByteHitRate { get; set; }

	        public string Qps { get; set; }

	        public string ReqErrRate { get; set; }

	        public string ReqHitRate { get; set; }

	        public string AvgResponseRate { get; set; }

	        public string TotalBytes { get; set; }

	        public string BytesProportion { get; set; }

	        public string TotalQuery { get; set; }
	    }
	}
}