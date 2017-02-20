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
	public class DescribeImportsForSQLServerResponse : AcsResponse
	{
	    public int? TotalRecordCounts { get; set; }

	    public int? PageNumber { get; set; }

	    public int? SQLItemsCounts { get; set; }

	    public List<SQLServerImport> Items { get; set; }

	    public class SQLServerImport{
	        public int? ImportId { get; set; }

	        public string FileName { get; set; }

	        public string DBName { get; set; }

	        public ImportStatusEnum? ImportStatus { get; set; }

	        public string StartTime { get; set; }

	        public enum ImportStatusEnum {
			
					Cancelling,
					Failed,
					Cancelled,
					Success,
					Importing,
					Pending,
			}
		}
	}
}