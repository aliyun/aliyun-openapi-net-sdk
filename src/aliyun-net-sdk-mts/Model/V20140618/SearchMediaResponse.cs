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
	public class SearchMediaResponse : AcsResponse
	{
	    public long? TotalNum { get; set; }

	    public long? PageNumber { get; set; }

	    public long? PageSize { get; set; }

	    public List<Media> MediaList { get; set; }

	    public class Media{
	        public string MediaId { get; set; }

	        public string Title { get; set; }

	        public string Description { get; set; }

	        public string CoverURL { get; set; }

	        public long? CateId { get; set; }

	        public string Duration { get; set; }

	        public string Format { get; set; }

	        public string Size { get; set; }

	        public string Bitrate { get; set; }

	        public string Width { get; set; }

	        public string Height { get; set; }

	        public string Fps { get; set; }

	        public string PublishState { get; set; }

	        public string CreationTime { get; set; }

	        public List<string> Tags { get; set; }

	        public List<string> RunIdList { get; set; }

	        public File_ File { get; set; }

	        public class File_{
	            public string URL { get; set; }

	            public string State { get; set; }
	        }
		}
	}
}