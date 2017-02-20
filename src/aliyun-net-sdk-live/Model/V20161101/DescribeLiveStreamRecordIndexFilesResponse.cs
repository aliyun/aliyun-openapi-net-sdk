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

namespace Aliyun.Acs.Live.Model.V20161101
{
	public class DescribeLiveStreamRecordIndexFilesResponse : AcsResponse
	{
	    public int? PageNum { get; set; }

	    public int? PageSize { get; set; }

	    public string Order { get; set; }

	    public int? TotalNum { get; set; }

	    public int? TotalPage { get; set; }

	    public List<RecordIndexInfo> RecordIndexInfoList { get; set; }

	    public class RecordIndexInfo{
	        public string RecordId { get; set; }

	        public string RecordUrl { get; set; }

	        public string DomainName { get; set; }

	        public string AppName { get; set; }

	        public string StreamName { get; set; }

	        public string OssBucket { get; set; }

	        public string OssEndpoint { get; set; }

	        public string OssObject { get; set; }

	        public string StartTime { get; set; }

	        public string EndTime { get; set; }

	        public float? Duration { get; set; }

	        public int? Height { get; set; }

	        public int? Width { get; set; }

	        public string CreateTime { get; set; }
	    }
	}
}