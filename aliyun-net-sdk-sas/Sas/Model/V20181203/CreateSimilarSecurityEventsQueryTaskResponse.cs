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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class CreateSimilarSecurityEventsQueryTaskResponse : AcsResponse
	{

		private string requestId;

		private CreateSimilarSecurityEventsQueryTask_CreateSimilarSecurityEventsQueryTaskResponse1 createSimilarSecurityEventsQueryTaskResponse1;

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

		public CreateSimilarSecurityEventsQueryTask_CreateSimilarSecurityEventsQueryTaskResponse1 CreateSimilarSecurityEventsQueryTaskResponse1
		{
			get
			{
				return createSimilarSecurityEventsQueryTaskResponse1;
			}
			set	
			{
				createSimilarSecurityEventsQueryTaskResponse1 = value;
			}
		}

		public class CreateSimilarSecurityEventsQueryTask_CreateSimilarSecurityEventsQueryTaskResponse1
		{

			private long? taskId;

			private string status;

			public long? TaskId
			{
				get
				{
					return taskId;
				}
				set	
				{
					taskId = value;
				}
			}

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}
		}
	}
}
