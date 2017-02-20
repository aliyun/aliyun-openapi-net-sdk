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
	public class DescribeAbnormalDBInstancesResponse : AcsResponse
	{
	    public int? TotalRecordCount { get; set; }

	    public int? PageNumber { get; set; }

	    public int? PageRecordCount { get; set; }

	    public List<InstanceResult> Items { get; set; }

	    public class InstanceResult{
	        public string DBInstanceDescription { get; set; }

	        public string DBInstanceId { get; set; }

	        public List<AbnormalItem> AbnormalItems { get; set; }

	        public class AbnormalItem{
	            public string CheckTime { get; set; }

	            public string CheckItem { get; set; }

	            public string AbnormalReason { get; set; }

	            public string AbnormalValue { get; set; }

	            public string AbnormalDetail { get; set; }

	            public string AdviceKey { get; set; }

	            public List<string> AdviseValue { get; set; }
	        }
		}
	}
}