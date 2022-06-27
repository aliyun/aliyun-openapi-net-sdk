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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class ExportVulResponse : AcsResponse
	{

		private string link;

		private int? progress;

		private string requestId;

		private int? currentCount;

		private string message;

		private string fileName;

		private int? totalCount;

		private string exportStatus;

		private long? id;

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

		public string ExportStatus
		{
			get
			{
				return exportStatus;
			}
			set	
			{
				exportStatus = value;
			}
		}

		public long? Id
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
	}
}
