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

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeTaskAttributeResponse : AcsResponse
	{
	    public string TaskId { get; set; }

	    public string RegionId { get; set; }

	    public string TaskAction { get; set; }

	    public string TaskStatus { get; set; }

	    public string TaskProcess { get; set; }

	    public string SupportCancel { get; set; }

	    public int? TotalCount { get; set; }

	    public int? SuccessCount { get; set; }

	    public int? FailedCount { get; set; }

	    public string CreationTime { get; set; }

	    public string FinishedTime { get; set; }

	    public List<OperationProgress> OperationProgressSet { get; set; }

	    public class OperationProgress{
	        public string OperationStatus { get; set; }

	        public string ErrorCode { get; set; }

	        public string ErrorMsg { get; set; }

	        public List<RelatedItem> RelatedItemSet { get; set; }

	        public class RelatedItem{
			    public string Name { get; set; }

			    public string Value { get; set; }
			}
		}
	}
}