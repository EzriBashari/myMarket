Server listening on 8080
<ref *2> IncomingMessage {
  _readableState: ReadableState {
    objectMode: false,
    highWaterMark: 16384,
    buffer: BufferList { head: null, tail: null, length: 0 },     
    length: 0,
    pipes: [],
    flowing: null,
    ended: false,
    endEmitted: false,
    reading: false,
    constructed: true,
    sync: true,
    needReadable: false,
    emittedReadable: false,
    readableListening: false,
    resumeScheduled: false,
    errorEmitted: false,
    emitClose: true,
    autoDestroy: true,
    destroyed: false,
    errored: null,
    closed: false,
    closeEmitted: false,
    defaultEncoding: 'utf8',
    awaitDrainWriters: null,
    multiAwaitDrain: false,
    readingMore: true,
    dataEmitted: false,
    decoder: null,
    encoding: null,
    [Symbol(kPaused)]: null
  },
  _events: [Object: null prototype] {},
  _eventsCount: 0,
  _maxListeners: undefined,
  socket: <ref *1> Socket {
    connecting: false,
    _hadError: false,
    _parent: null,
    _host: null,
    _closeAfterHandlingError: false,
    _readableState: ReadableState {
      objectMode: false,
      highWaterMark: 16384,
      buffer: BufferList { head: null, tail: null, length: 0 },   
      length: 0,
      pipes: [],
      flowing: true,
      ended: false,
      endEmitted: false,
      reading: true,
      constructed: true,
      sync: false,
      needReadable: true,
      emittedReadable: false,
      readableListening: false,
      resumeScheduled: false,
      errorEmitted: false,
      emitClose: false,
      autoDestroy: true,
      destroyed: false,
      errored: null,
      closed: false,
      closeEmitted: false,
      defaultEncoding: 'utf8',
      awaitDrainWriters: null,
      multiAwaitDrain: false,
      readingMore: false,
      dataEmitted: false,
      decoder: null,
      encoding: null,
      [Symbol(kPaused)]: false
    },
    _events: [Object: null prototype] {
      end: [Array],
      timeout: [Function: socketOnTimeout],
      data: [Function: bound socketOnData],
      error: [Function: socketOnError],
      close: [Array],
      drain: [Function: bound socketOnDrain],
      resume: [Function: onSocketResume],
      pause: [Function: onSocketPause]
    },
    _eventsCount: 8,
    _maxListeners: undefined,
    _writableState: WritableState {
      objectMode: false,
      highWaterMark: 16384,
      finalCalled: false,
      needDrain: false,
      ending: false,
      ended: false,
      finished: false,
      destroyed: false,
      decodeStrings: false,
      defaultEncoding: 'utf8',
      length: 0,
      writing: false,
      corked: 0,
      sync: true,
      bufferProcessing: false,
      onwrite: [Function: bound onwrite],
      writecb: null,
      writelen: 0,
      afterWriteTickInfo: null,
      buffered: [],
      bufferedIndex: 0,
      allBuffers: true,
      allNoop: true,
      pendingcb: 0,
      constructed: true,
      prefinished: false,
      errorEmitted: false,
      emitClose: false,
      autoDestroy: true,
      errored: null,
      closed: false,
      closeEmitted: false,
      [Symbol(kOnFinished)]: []
    },
    allowHalfOpen: true,
    _sockname: null,
    _pendingData: null,
    _pendingEncoding: '',
    server: Server {
      maxHeaderSize: undefined,
      insecureHTTPParser: undefined,
      requestTimeout: 300000,
      headersTimeout: 60000,
      keepAliveTimeout: 5000,
      connectionsCheckingInterval: 30000,
      _events: [Object: null prototype],
      _eventsCount: 2,
      _maxListeners: undefined,
      _connections: 2,
      _handle: [TCP],
      _usingWorkers: false,
      _workers: [],
      _unref: false,
      allowHalfOpen: true,
      pauseOnConnect: false,
      noDelay: true,
      keepAlive: false,
      keepAliveInitialDelay: 0,
      httpAllowHalfOpen: false,
      timeout: 0,
      maxHeadersCount: null,
      maxRequestsPerSocket: 0,
      _connectionKey: '6::::8080',
      [Symbol(IncomingMessage)]: [Function: IncomingMessage],     
      [Symbol(ServerResponse)]: [Function: ServerResponse],       
      [Symbol(kCapture)]: false,
      [Symbol(async_id_symbol)]: 12,
      [Symbol(http.server.connections)]: ConnectionsList {},      
      [Symbol(http.server.connectionsCheckingInterval)]: Timeout {
        _idleTimeout: 30000,
        _idlePrev: [TimersList],
        _idleNext: [TimersList],
        _idleStart: 465,
        _onTimeout: [Function: bound checkConnections],
        _timerArgs: undefined,
        _repeat: 30000,
        _destroyed: false,
        [Symbol(refed)]: false,
        [Symbol(kHasPrimitive)]: false,
        [Symbol(asyncId)]: 11,
        [Symbol(triggerId)]: 1
      },
      [Symbol(kUniqueHeaders)]: null
    },
    _server: Server {
      maxHeaderSize: undefined,
      insecureHTTPParser: undefined,
      requestTimeout: 300000,
      headersTimeout: 60000,
      keepAliveTimeout: 5000,
      connectionsCheckingInterval: 30000,
      _events: [Object: null prototype],
      _eventsCount: 2,
      _maxListeners: undefined,
      _connections: 2,
      _handle: [TCP],
      _usingWorkers: false,
      _workers: [],
      _unref: false,
      allowHalfOpen: true,
      pauseOnConnect: false,
      noDelay: true,
      keepAlive: false,
      keepAliveInitialDelay: 0,
      httpAllowHalfOpen: false,
      timeout: 0,
      maxHeadersCount: null,
      maxRequestsPerSocket: 0,
      _connectionKey: '6::::8080',
      [Symbol(IncomingMessage)]: [Function: IncomingMessage],     
      [Symbol(ServerResponse)]: [Function: ServerResponse],       
      [Symbol(kCapture)]: false,
      [Symbol(async_id_symbol)]: 12,
      [Symbol(http.server.connections)]: ConnectionsList {},      
      [Symbol(http.server.connectionsCheckingInterval)]: Timeout {
        _idleTimeout: 30000,
        _idlePrev: [TimersList],
        _idleNext: [TimersList],
        _idleStart: 465,
        _onTimeout: [Function: bound checkConnections],
        _timerArgs: undefined,
        _repeat: 30000,
        _destroyed: false,
        [Symbol(refed)]: false,
        [Symbol(kHasPrimitive)]: false,
        [Symbol(asyncId)]: 11,
        [Symbol(triggerId)]: 1
      },
      [Symbol(kUniqueHeaders)]: null
    },
    parser: HTTPParser {
      '0': null,
      '1': [Function: parserOnHeaders],
      '2': [Function: parserOnHeadersComplete],
      '3': [Function: parserOnBody],
      '4': [Function: parserOnMessageComplete],
      '5': [Function: bound onParserExecute],
      '6': [Function: bound onParserTimeout],
      _headers: [],
      _url: '',
      socket: [Circular *1],
      incoming: [Circular *2],
      outgoing: null,
      maxHeaderPairs: 2000,
      _consumed: true,
      onIncoming: [Function: bound parserOnIncoming],
      [Symbol(resource_symbol)]: [HTTPServerAsyncResource]        
    },
    on: [Function: socketListenerWrap],
    addListener: [Function: socketListenerWrap],
    prependListener: [Function: socketListenerWrap],
    setEncoding: [Function: socketSetEncoding],
    _paused: false,
    _httpMessage: ServerResponse {
      _events: [Object: null prototype],
      _eventsCount: 1,
      _maxListeners: undefined,
      outputData: [],
      outputSize: 0,
      writable: true,
      destroyed: false,
      _last: false,
      chunkedEncoding: false,
      shouldKeepAlive: true,
      maxRequestsOnConnectionReached: false,
      _defaultKeepAlive: true,
      useChunkedEncodingByDefault: true,
      sendDate: true,
      _removedConnection: false,
      _removedContLen: false,
      _removedTE: false,
      strictContentLength: false,
      _contentLength: null,
      _hasBody: true,
      _trailer: '',
      finished: false,
      _headerSent: false,
      _closed: false,
      socket: [Circular *1],
      _header: null,
      _keepAliveTimeout: 5000,
      _onPendingData: [Function: bound updateOutgoingData],       
      req: [Circular *2],
      _sent100: false,
      _expect_continue: false,
      _maxRequestsPerSocket: 0,
      locals: [Object: null prototype] {},
      [Symbol(kCapture)]: false,
      [Symbol(kBytesWritten)]: 0,
      [Symbol(kEndCalled)]: false,
      [Symbol(kNeedDrain)]: false,
      [Symbol(corked)]: 0,
      [Symbol(kOutHeaders)]: [Object: null prototype],
      [Symbol(kUniqueHeaders)]: null
    },
    [Symbol(async_id_symbol)]: 30,
    [Symbol(kHandle)]: TCP {
      reading: true,
      onconnection: null,
      _consumed: true,
      [Symbol(owner_symbol)]: [Circular *1]
    },
    [Symbol(lastWriteQueueSize)]: 0,
    [Symbol(timeout)]: null,
    [Symbol(kBuffer)]: null,
    [Symbol(kBufferCb)]: null,
    [Symbol(kBufferGen)]: null,
    [Symbol(kCapture)]: false,
    [Symbol(kSetNoDelay)]: true,
    [Symbol(kSetKeepAlive)]: false,
    [Symbol(kSetKeepAliveInitialDelay)]: 0,
    [Symbol(kBytesRead)]: 0,
    [Symbol(kBytesWritten)]: 0
  },
  httpVersionMajor: 1,
  httpVersionMinor: 1,
  httpVersion: '1.1',
  complete: false,
  rawHeaders: [
    'Host',
    'localhost:8080',
    'Connection',
    'keep-alive',
    'sec-ch-ua',
    '"Not/A)Brand";v="99", "Google Chrome";v="115", "Chromium";v="115"',
    'Accept',
    'application/json, text/plain, */*',
    'sec-ch-ua-mobile',
    '?0',
    'User-Agent',
    'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/115.0.0.0 Safari/537.36',
    'sec-ch-ua-platform',
    '"Windows"',
    'Origin',
    'http://localhost:3000',
    'Sec-Fetch-Site',
    'same-site',
    'Sec-Fetch-Mode',
    'cors',
    'Sec-Fetch-Dest',
    'empty',
    'Referer',
    'http://localhost:3000/',
    'Accept-Encoding',
    'gzip, deflate, br',
    'Accept-Language',
    'en-US,en;q=0.9',
    'Cookie',
    'isAdmin=0; userID=207324282; role=buyer'
  ],
  rawTrailers: [],
  aborted: false,
  upgrade: false,
  url: '/removeFromCart',
  method: 'DELETE',
  statusCode: null,
  statusMessage: null,
  client: <ref *1> Socket {
    connecting: false,
    _hadError: false,
    _parent: null,
    _host: null,
    _closeAfterHandlingError: false,
    _readableState: ReadableState {
      objectMode: false,
      highWaterMark: 16384,
      buffer: BufferList { head: null, tail: null, length: 0 },   
      length: 0,
      pipes: [],
      flowing: true,
      ended: false,
      endEmitted: false,
      reading: true,
      constructed: true,
      sync: false,
      needReadable: true,
      emittedReadable: false,
      readableListening: false,
      resumeScheduled: false,
      errorEmitted: false,
      emitClose: false,
      autoDestroy: true,
      destroyed: false,
      errored: null,
      closed: false,
      closeEmitted: false,
      defaultEncoding: 'utf8',
      awaitDrainWriters: null,
      multiAwaitDrain: false,
      readingMore: false,
      dataEmitted: false,
      decoder: null,
      encoding: null,
      [Symbol(kPaused)]: false
    },
    _events: [Object: null prototype] {
      end: [Array],
      timeout: [Function: socketOnTimeout],
      data: [Function: bound socketOnData],
      error: [Function: socketOnError],
      close: [Array],
      drain: [Function: bound socketOnDrain],
      resume: [Function: onSocketResume],
      pause: [Function: onSocketPause]
    },
    _eventsCount: 8,
    _maxListeners: undefined,
    _writableState: WritableState {
      objectMode: false,
      highWaterMark: 16384,
      finalCalled: false,
      needDrain: false,
      ending: false,
      ended: false,
      finished: false,
      destroyed: false,
      decodeStrings: false,
      defaultEncoding: 'utf8',
      length: 0,
      writing: false,
      corked: 0,
      sync: true,
      bufferProcessing: false,
      onwrite: [Function: bound onwrite],
      writecb: null,
      writelen: 0,
      afterWriteTickInfo: null,
      buffered: [],
      bufferedIndex: 0,
      allBuffers: true,
      allNoop: true,
      pendingcb: 0,
      constructed: true,
      prefinished: false,
      errorEmitted: false,
      emitClose: false,
      autoDestroy: true,
      errored: null,
      closed: false,
      closeEmitted: false,
      [Symbol(kOnFinished)]: []
    },
    allowHalfOpen: true,
    _sockname: null,
    _pendingData: null,
    _pendingEncoding: '',
    server: Server {
      maxHeaderSize: undefined,
      insecureHTTPParser: undefined,
      requestTimeout: 300000,
      headersTimeout: 60000,
      keepAliveTimeout: 5000,
      connectionsCheckingInterval: 30000,
      _events: [Object: null prototype],
      _eventsCount: 2,
      _maxListeners: undefined,
      _connections: 2,
      _handle: [TCP],
      _usingWorkers: false,
      _workers: [],
      _unref: false,
      allowHalfOpen: true,
      pauseOnConnect: false,
      noDelay: true,
      keepAlive: false,
      keepAliveInitialDelay: 0,
      httpAllowHalfOpen: false,
      timeout: 0,
      maxHeadersCount: null,
      maxRequestsPerSocket: 0,
      _connectionKey: '6::::8080',
      [Symbol(IncomingMessage)]: [Function: IncomingMessage],     
      [Symbol(ServerResponse)]: [Function: ServerResponse],       
      [Symbol(kCapture)]: false,
      [Symbol(async_id_symbol)]: 12,
      [Symbol(http.server.connections)]: ConnectionsList {},      
      [Symbol(http.server.connectionsCheckingInterval)]: Timeout {
        _idleTimeout: 30000,
        _idlePrev: [TimersList],
        _idleNext: [TimersList],
        _idleStart: 465,
        _onTimeout: [Function: bound checkConnections],
        _timerArgs: undefined,
        _repeat: 30000,
        _destroyed: false,
        [Symbol(refed)]: false,
        [Symbol(kHasPrimitive)]: false,
        [Symbol(asyncId)]: 11,
        [Symbol(triggerId)]: 1
      },
      [Symbol(kUniqueHeaders)]: null
    },
    _server: Server {
      maxHeaderSize: undefined,
      insecureHTTPParser: undefined,
      requestTimeout: 300000,
      headersTimeout: 60000,
      keepAliveTimeout: 5000,
      connectionsCheckingInterval: 30000,
      _events: [Object: null prototype],
      _eventsCount: 2,
      _maxListeners: undefined,
      _connections: 2,
      _handle: [TCP],
      _usingWorkers: false,
      _workers: [],
      _unref: false,
      allowHalfOpen: true,
      pauseOnConnect: false,
      noDelay: true,
      keepAlive: false,
      keepAliveInitialDelay: 0,
      httpAllowHalfOpen: false,
      timeout: 0,
      maxHeadersCount: null,
      maxRequestsPerSocket: 0,
      _connectionKey: '6::::8080',
      [Symbol(IncomingMessage)]: [Function: IncomingMessage],     
      [Symbol(ServerResponse)]: [Function: ServerResponse],       
      [Symbol(kCapture)]: false,
      [Symbol(async_id_symbol)]: 12,
      [Symbol(http.server.connections)]: ConnectionsList {},      
      [Symbol(http.server.connectionsCheckingInterval)]: Timeout {
        _idleTimeout: 30000,
        _idlePrev: [TimersList],
        _idleNext: [TimersList],
        _idleStart: 465,
        _onTimeout: [Function: bound checkConnections],
        _timerArgs: undefined,
        _repeat: 30000,
        _destroyed: false,
        [Symbol(refed)]: false,
        [Symbol(kHasPrimitive)]: false,
        [Symbol(asyncId)]: 11,
        [Symbol(triggerId)]: 1
      },
      [Symbol(kUniqueHeaders)]: null
    },
    parser: HTTPParser {
      '0': null,
      '1': [Function: parserOnHeaders],
      '2': [Function: parserOnHeadersComplete],
      '3': [Function: parserOnBody],
      '4': [Function: parserOnMessageComplete],
      '5': [Function: bound onParserExecute],
      '6': [Function: bound onParserTimeout],
      _headers: [],
      _url: '',
      socket: [Circular *1],
      incoming: [Circular *2],
      outgoing: null,
      maxHeaderPairs: 2000,
      _consumed: true,
      onIncoming: [Function: bound parserOnIncoming],
      [Symbol(resource_symbol)]: [HTTPServerAsyncResource]        
    },
    on: [Function: socketListenerWrap],
    addListener: [Function: socketListenerWrap],
    prependListener: [Function: socketListenerWrap],
    setEncoding: [Function: socketSetEncoding],
    _paused: false,
    _httpMessage: ServerResponse {
      _events: [Object: null prototype],
      _eventsCount: 1,
      _maxListeners: undefined,
      outputData: [],
      outputSize: 0,
      writable: true,
      destroyed: false,
      _last: false,
      chunkedEncoding: false,
      shouldKeepAlive: true,
      maxRequestsOnConnectionReached: false,
      _defaultKeepAlive: true,
      useChunkedEncodingByDefault: true,
      sendDate: true,
      _removedConnection: false,
      _removedContLen: false,
      _removedTE: false,
      strictContentLength: false,
      _contentLength: null,
      _hasBody: true,
      _trailer: '',
      finished: false,
      _headerSent: false,
      _closed: false,
      socket: [Circular *1],
      _header: null,
      _keepAliveTimeout: 5000,
      _onPendingData: [Function: bound updateOutgoingData],       
      req: [Circular *2],
      _sent100: false,
      _expect_continue: false,
      _maxRequestsPerSocket: 0,
      locals: [Object: null prototype] {},
      [Symbol(kCapture)]: false,
      [Symbol(kBytesWritten)]: 0,
      [Symbol(kEndCalled)]: false,
      [Symbol(kNeedDrain)]: false,
      [Symbol(corked)]: 0,
      [Symbol(kOutHeaders)]: [Object: null prototype],
      [Symbol(kUniqueHeaders)]: null
    },
    [Symbol(async_id_symbol)]: 30,
    [Symbol(kHandle)]: TCP {
      reading: true,
      onconnection: null,
      _consumed: true,
      [Symbol(owner_symbol)]: [Circular *1]
    },
    [Symbol(lastWriteQueueSize)]: 0,
    [Symbol(timeout)]: null,
    [Symbol(kBuffer)]: null,
    [Symbol(kBufferCb)]: null,
    [Symbol(kBufferGen)]: null,
    [Symbol(kCapture)]: false,
    [Symbol(kSetNoDelay)]: true,
    [Symbol(kSetKeepAlive)]: false,
    [Symbol(kSetKeepAliveInitialDelay)]: 0,
    [Symbol(kBytesRead)]: 0,
    [Symbol(kBytesWritten)]: 0
  },
  _consuming: false,
  _dumped: false,
  next: [Function: next],
  baseUrl: '/api',
  originalUrl: '/api/removeFromCart',
  _parsedUrl: Url {
    protocol: null,
    slashes: null,
    auth: null,
    host: null,
    port: null,
    hostname: null,
    hash: null,
    search: null,
    query: null,
    pathname: '/removeFromCart',
    path: '/removeFromCart',
    href: '/removeFromCart',
    _raw: '/removeFromCart'
  },
  params: {},
  query: {},
  res: <ref *3> ServerResponse {
    _events: [Object: null prototype] { finish: [Function: bound resOnFinish] },
    _eventsCount: 1,
    _maxListeners: undefined,
    outputData: [],
    outputSize: 0,
    writable: true,
    destroyed: false,
    _last: false,
    chunkedEncoding: false,
    shouldKeepAlive: true,
    maxRequestsOnConnectionReached: false,
    _defaultKeepAlive: true,
    useChunkedEncodingByDefault: true,
    sendDate: true,
    _removedConnection: false,
    _removedContLen: false,
    _removedTE: false,
    strictContentLength: false,
    _contentLength: null,
    _hasBody: true,
    _trailer: '',
    finished: false,
    _headerSent: false,
    _closed: false,
    socket: <ref *1> Socket {
      connecting: false,
      _hadError: false,
      _parent: null,
      _host: null,
      _closeAfterHandlingError: false,
      _readableState: [ReadableState],
      _events: [Object: null prototype],
      _eventsCount: 8,
      _maxListeners: undefined,
      _writableState: [WritableState],
      allowHalfOpen: true,
      _sockname: null,
      _pendingData: null,
      _pendingEncoding: '',
      server: [Server],
      _server: [Server],
      parser: [HTTPParser],
      on: [Function: socketListenerWrap],
      addListener: [Function: socketListenerWrap],
      prependListener: [Function: socketListenerWrap],
      setEncoding: [Function: socketSetEncoding],
      _paused: false,
      _httpMessage: [Circular *3],
      [Symbol(async_id_symbol)]: 30,
      [Symbol(kHandle)]: [TCP],
      [Symbol(lastWriteQueueSize)]: 0,
      [Symbol(timeout)]: null,
      [Symbol(kBuffer)]: null,
      [Symbol(kBufferCb)]: null,
      [Symbol(kBufferGen)]: null,
      [Symbol(kCapture)]: false,
      [Symbol(kSetNoDelay)]: true,
      [Symbol(kSetKeepAlive)]: false,
      [Symbol(kSetKeepAliveInitialDelay)]: 0,
      [Symbol(kBytesRead)]: 0,
      [Symbol(kBytesWritten)]: 0
    },
    _header: null,
    _keepAliveTimeout: 5000,
    _onPendingData: [Function: bound updateOutgoingData],
    req: [Circular *2],
    _sent100: false,
    _expect_continue: false,
    _maxRequestsPerSocket: 0,
    locals: [Object: null prototype] {},
    [Symbol(kCapture)]: false,
    [Symbol(kBytesWritten)]: 0,
    [Symbol(kEndCalled)]: false,
    [Symbol(kNeedDrain)]: false,
    [Symbol(corked)]: 0,
    [Symbol(kOutHeaders)]: [Object: null prototype] {
      'x-powered-by': [Array],
      'access-control-allow-origin': [Array],
      vary: [Array],
      'access-control-allow-credentials': [Array]
    },
    [Symbol(kUniqueHeaders)]: null
  },
  body: {},
  route: Route {
    path: '/removeFromCart',
    stack: [ [Layer] ],
    methods: { delete: true }
  },
  [Symbol(kCapture)]: false,
  [Symbol(kHeaders)]: {
    host: 'localhost:8080',
    connection: 'keep-alive',
    'sec-ch-ua': '"Not/A)Brand";v="99", "Google Chrome";v="115", "Chromium";v="115"',
    accept: 'application/json, text/plain, */*',
    'sec-ch-ua-mobile': '?0',
    'user-agent': 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/115.0.0.0 Safari/537.36',
    'sec-ch-ua-platform': '"Windows"',
    origin: 'http://localhost:3000',
    'sec-fetch-site': 'same-site',
    'sec-fetch-mode': 'cors',
    'sec-fetch-dest': 'empty',
    referer: 'http://localhost:3000/',
    'accept-encoding': 'gzip, deflate, br',
    'accept-language': 'en-US,en;q=0.9',
    cookie: 'isAdmin=0; userID=207324282; role=buyer'
  },
  [Symbol(kHeadersCount)]: 30,
  [Symbol(kTrailers)]: null,