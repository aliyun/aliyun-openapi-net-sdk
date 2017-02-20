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

namespace Aliyun.Acs.Mts.Model.V20140618
{
	public class SearchMediaWorkflowExecutionResponse : AcsResponse
	{
	    public long? TotalCount { get; set; }

	    public long? PageNumber { get; set; }

	    public long? PageSize { get; set; }

	    public List<MediaWorkflowExecution> MediaWorkflowExecutionList { get; set; }

	    public class MediaWorkflowExecution{
	        public string RunId { get; set; }

	        public string Name { get; set; }

	        public string State { get; set; }

	        public string MediaId { get; set; }

	        public string CreationTime { get; set; }

	        public List<Activity> ActivityList { get; set; }

	        public Input_ Input { get; set; }

	        public class Activity{
	            public string Name { get; set; }

	            public string Type { get; set; }

	            public string JobId { get; set; }

	            public string State { get; set; }

	            public string Code { get; set; }

	            public string Message { get; set; }

	            public string StartTime { get; set; }

	            public string EndTime { get; set; }
	        }

			public class Input_{
			    public InputFile_ InputFile { get; set; }

			    public class InputFile_{
			        public string Bucket { get; set; }

			        public string Location { get; set; }

			        public string Object { get; set; }
			    }
			}
		}
	}
}