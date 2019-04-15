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
	public class DescribeExportInfoResponse : AcsResponse
	{

		private string requestId;

		private string fileName;

		private int? currentCount;

		private string link;

		private int? progress;

		private int? id;

		private string message;

		private int? totalCount;

		private long? gmtCreate;

		private string resultStatus;

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

		public string FileName
		{
			get
			{
				return fileName;
			}
			set	
			{
				fileName = value;
			}
		}

		public int? CurrentCount
		{
			get
			{
				return currentCount;
			}
			set	
			{
				currentCount = value;
			}
		}

		public string Link
		{
			get
			{
				return link;
			}
			set	
			{
				link = value;
			}
		}

		public int? Progress
		{
			get
			{
				return progress;
			}
			set	
			{
				progress = value;
			}
		}

		public int? Id
		{
			get
			{
				return id;
			}
			set	
			{
				id = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public long? GmtCreate
		{
			get
			{
				return gmtCreate;
			}
			set	
			{
				gmtCreate = value;
			}
		}

		public string ResultStatus
		{
			get
			{
				return resultStatus;
			}
			set	
			{
				resultStatus = value;
			}
		}
	}
}
