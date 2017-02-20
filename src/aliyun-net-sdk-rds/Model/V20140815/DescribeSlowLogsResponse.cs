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
	public class DescribeSlowLogsResponse : AcsResponse
	{
	    public string Engine { get; set; }

	    public string StartTime { get; set; }

	    public string EndTime { get; set; }

	    public int? TotalRecordCount { get; set; }

	    public int? PageNumber { get; set; }

	    public int? PageRecordCount { get; set; }

	    public List<SQLSlowLog> Items { get; set; }

	    public class SQLSlowLog{
	        public long? SlowLogId { get; set; }

	        public long? SQLId { get; set; }

	        public string DBName { get; set; }

	        public string SQLText { get; set; }

	        public long? MySQLTotalExecutionCounts { get; set; }

	        public long? MySQLTotalExecutionTimes { get; set; }

	        public long? TotalLockTimes { get; set; }

	        public long? MaxLockTime { get; set; }

	        public long? ParseTotalRowCounts { get; set; }

	        public long? ParseMaxRowCount { get; set; }

	        public long? ReturnTotalRowCounts { get; set; }

	        public long? ReturnMaxRowCount { get; set; }

	        public string CreateTime { get; set; }

	        public long? SQLServerTotalExecutionCounts { get; set; }

	        public long? SQLServerTotalExecutionTimes { get; set; }

	        public long? TotalLogicalReadCounts { get; set; }

	        public long? TotalPhysicalReadCounts { get; set; }

	        public string ReportTime { get; set; }

	        public long? MaxExecutionTime { get; set; }

	        public long? AvgExecutionTime { get; set; }
	    }
	}
}