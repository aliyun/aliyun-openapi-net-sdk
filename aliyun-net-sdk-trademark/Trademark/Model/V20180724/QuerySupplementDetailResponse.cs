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

namespace Aliyun.Acs.Trademark.Model.V20180724
{
	public class QuerySupplementDetailResponse : AcsResponse
	{

		private string requestId;

		private long? id;

		private string serialNumber;

		private int? type;

		private int? status;

		private string tmNumber;

		private long? sendTime;

		private long? acceptTime;

		private long? sbjDeadTime;

		private long? acceptDeadTime;

		private long? operateTime;

		private string uploadFileTemplateUrl;

		private string content;

		private List<string> fileTemplateUrls;

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

		public string SerialNumber
		{
			get
			{
				return serialNumber;
			}
			set	
			{
				serialNumber = value;
			}
		}

		public int? Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
			}
		}

		public int? Status
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

		public string TmNumber
		{
			get
			{
				return tmNumber;
			}
			set	
			{
				tmNumber = value;
			}
		}

		public long? SendTime
		{
			get
			{
				return sendTime;
			}
			set	
			{
				sendTime = value;
			}
		}

		public long? AcceptTime
		{
			get
			{
				return acceptTime;
			}
			set	
			{
				acceptTime = value;
			}
		}

		public long? SbjDeadTime
		{
			get
			{
				return sbjDeadTime;
			}
			set	
			{
				sbjDeadTime = value;
			}
		}

		public long? AcceptDeadTime
		{
			get
			{
				return acceptDeadTime;
			}
			set	
			{
				acceptDeadTime = value;
			}
		}

		public long? OperateTime
		{
			get
			{
				return operateTime;
			}
			set	
			{
				operateTime = value;
			}
		}

		public string UploadFileTemplateUrl
		{
			get
			{
				return uploadFileTemplateUrl;
			}
			set	
			{
				uploadFileTemplateUrl = value;
			}
		}

		public string Content
		{
			get
			{
				return content;
			}
			set	
			{
				content = value;
			}
		}

		public List<string> FileTemplateUrls
		{
			get
			{
				return fileTemplateUrls;
			}
			set	
			{
				fileTemplateUrls = value;
			}
		}
	}
}
