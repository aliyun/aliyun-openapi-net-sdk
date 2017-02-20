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
	public class DescribeCdnDomainLogsResponse : AcsResponse
	{
	    public long? PageNumber { get; set; }

	    public long? PageSize { get; set; }

	    public long? TotalCount { get; set; }

	    public DomainLogModel_ DomainLogModel { get; set; }

	    public class DomainLogModel_{
	        public string DomainName { get; set; }

	        public List<DomainLogDetail> DomainLogDetails { get; set; }

	        public class DomainLogDetail{
	            public string LogName { get; set; }

	            public string LogPath { get; set; }

	            public long? LogSize { get; set; }

	            public string StartTime { get; set; }

	            public string EndTime { get; set; }
	        }
		}
	}
}